using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class BusUI : MonoBehaviour
{
    [SerializeField] public Text name, capacity, source, destination, timeElapsed, totalTime;

    BusInfo busStates;
    // Start is called before the first frame update
    void Start()
    {
        busStates = GetComponent<BusInfo>();
        timeElapsed.text = "wating time:" + busStates.watingTime[0].ToString();
    }

    void setStates()
    {
        name.text = "Bus name:"+busStates.busName.ToString();
        capacity.text = "Num of people:" + busStates.busCapcity.ToString();
        source.text = "Source:" + busStates.source.ToString();
        destination.text = "Destination:" + busStates.destination.ToString();
        

        totalTime.text = "TotalTime:" + busStates.totalTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        setStates();
        StartCoroutine(PostRequest("http://localhost:4040/bus/pick"));
    }

    IEnumerator PostRequest(string url)
    {
        WWWForm form = new WWWForm();
        form.AddField("busName", busStates.busName.ToString());
        form.AddField("maxCapacity",30);
        form.AddField("currentCapacity", busStates.busCapcity.ToString());
        form.AddField("source", busStates.source.ToString());
        form.AddField("destination", busStates.destination.ToString());
        form.AddField("totalTime", busStates.totalTime.ToString());

        UnityWebRequest uwr = UnityWebRequest.Post(url, form);
        yield return uwr.SendWebRequest();

        if (uwr.isNetworkError)
        {
            Debug.Log("Error While Sending: " + uwr.error);
        }
        else
        {
            Debug.Log("Received: " + uwr.downloadHandler.text);
        }
    }
}
