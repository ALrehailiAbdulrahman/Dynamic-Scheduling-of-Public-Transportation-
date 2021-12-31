using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusInfo : MonoBehaviour
{
    public string busName;
    public int busCapcity;
    public string source;
    public string destination;
   [SerializeField] public List<float> watingTime = new List<float>();
    public float totalTime;

    // Start is called before the first frame update
    void Start()
    {
        busName = gameObject.name;
        source = "dispatch";
        destination = GetComponent<Patrol>().points[0].name;
        watingTime[0] = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void SetBusCapcity(int capacity)
    {
        this.busCapcity = capacity;
    }
    public void SetBusSource(string source)
    {
        this.source = source;
    }
    public void SetBusDestination(string Destination)
    {
        this.destination = Destination;
    }



}
