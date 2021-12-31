using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class CollisionHandler : MonoBehaviour
{

    [SerializeField] public Text timeElapsed;
    public BusInfo bus;
    int counter=0;
    int point = 1;
    int counterWating = 0;
    float totalTime;

    private void Start()
    {
       
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stations"))
        {

           

            StartCoroutine(WaitForPickup());
            bus.SetBusSource(collision.gameObject.name);
            try
            {
                bus.SetBusDestination(GetComponent<Patrol>().points[point].name);
                bus.watingTime[point] = Time.timeSinceLevelLoad - TotalTime(totalTime);
                timeElapsed.text = "wating time:" + bus.watingTime[point].ToString();
                point++;
                counterWating++;
            }
            catch(System.Exception)
            {
                bus.SetBusDestination(GetComponent<Patrol>().points[0].name);
                bus.watingTime[point] = Time.timeSinceLevelLoad - TotalTime(totalTime);
                timeElapsed.text = "wating time:" + bus.watingTime[point].ToString();
                bus.totalTime = Time.timeSinceLevelLoad ;
                point = 1;
                counterWating = 0;
            }

            

        }
        if (collision.gameObject.CompareTag("People"))
        {
            Destroy(collision.gameObject, 2.5f);
            counter++;
            
        }

      

    }
  

    IEnumerator WaitForPickup()
    {
        GetComponent<NavMeshAgent>().speed = 0;
        yield return new WaitForSeconds(5f);
        bus.SetBusCapcity(counter);
        
        GetComponent<NavMeshAgent>().speed = 15;
    }

    float TotalTime(float sum)
    {
      
        for(int i = 0; i < GetComponent<Patrol>().points.Length; i++)
        {
            sum += bus.watingTime[i];
        }

        return sum;
    }


}
