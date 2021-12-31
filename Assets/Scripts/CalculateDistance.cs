using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateDistance : MonoBehaviour
{
    public GameObject bus;
    public GameObject [] station;

    public float Distance;
    public float TimeBetweenObjects;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        Distance = Vector3.Distance(bus.transform.position, station[0].transform.position);
        for (int i = 0; i < station.Length; i++)
        {
            try
            {
                Distance += Vector3.Distance(station[i].transform.position, station[i + 1].transform.position);
            }catch(System.Exception e)
            {
               
            }
        }


        TimeBetweenObjects = Distance / Speed;
       // Debug.Log(TimeBetweenObjects);
    }

    // Update is called once per frame
  
    void Update()
    {
      
        
    }
}
