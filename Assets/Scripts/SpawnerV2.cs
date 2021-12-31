using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerV2 : MonoBehaviour
{
    [SerializeField] GameObject people;


    [SerializeField] List<Transform> point = new List<Transform>();
 
    void Start()
    {
        GameObject [] stationLocations = GameObject.FindGameObjectsWithTag("Stations");
        foreach (GameObject item in stationLocations)
        {
            point.Add(item.transform);
        }

       
        
        
        for (int i = 0; i < point.Count; i++)
        {
            Spawn(point[i], UnityEngine.Random.Range(1, 5));
        }
       
    }

   
    void Spawn(Transform pos, int peopleCap)
    {
        Vector3 station = pos.position;
        //int peopleCap = UnityEngine.Random.Range(1, 5);
        for (int i = 0; i < peopleCap; i++)
        {
            float countx = UnityEngine.Random.Range(-1f, 1f);
            float countz = UnityEngine.Random.Range(-1f, 1f);
            station.x += countx;
            station.z += countz;
            Instantiate(people, station, Quaternion.identity);
        }
    }
}
