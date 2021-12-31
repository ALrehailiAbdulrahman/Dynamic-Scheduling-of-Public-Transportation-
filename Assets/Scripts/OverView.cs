using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OverView : MonoBehaviour
{
    [SerializeField] public Text numOfPeopleAll,totalTimeAll;
    bool isPressed;

    public GameObject []busStates;
    int allPeople;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    void setStates()
    {
        allPeople = busStates[0].GetComponent<BusInfo>().busCapcity +
            busStates[1].GetComponent<BusInfo>().busCapcity +
            busStates[2].GetComponent<BusInfo>().busCapcity;

    }

    // Update is called once per frame
    void Update()
    {
        setStates();
        numOfPeopleAll.text = "number of people:" + allPeople.ToString();
        totalTimeAll.text = "Time to pick all people:" + Time.timeSinceLevelLoad;
        if (GameObject.Find("people Variant(Clone)") == null)
            StartCoroutine(Deley());

        if (Input.GetKeyDown(KeyCode.Space) )
        {
            if (!isPressed)
            {
                Time.timeScale = 1;
                isPressed = true;
            }
            else
            {
                Time.timeScale = 0;
                isPressed = false;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            NextScene();
            
        }
        if (Input.GetKeyDown(KeyCode.K))
            ReloadScene();
    }
    IEnumerator Deley()
    {
        
        yield return new WaitForSeconds(3f);
        Time.timeScale = 0;

    }
    void NextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
            nextSceneIndex = 0;
        SceneManager.LoadScene(nextSceneIndex);
    }
    void ReloadScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
