using UnityEngine;
using System.Collections;
using System;

public class Spawner : MonoBehaviour
{
    public GameObject people;

    void Start()
    {
        
        for (int i = 1; i <= GameObject.FindGameObjectsWithTag("Stations").Length; i++)
        {
            Spawn("Station (" + i.ToString() + ")");
        }
    }
    void Spawn(string pos)
    {
        Vector3 station = GameObject.Find(pos).transform.position;
        int peopleCap = UnityEngine.Random.Range(1, 5);
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