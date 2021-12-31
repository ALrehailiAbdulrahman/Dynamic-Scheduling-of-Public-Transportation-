using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPeople : MonoBehaviour
{
    public GameObject people;
    public BusInfo bus;

    private void Start()
    {
        bus = GetComponent<BusInfo>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stations"))
        {
            int dropRandom = UnityEngine.Random.Range(0, bus.busCapcity);
            if ((bus.busCapcity - dropRandom) >= 0)
            {
                
                for (int i = 1; i <= dropRandom; i++)
                {
                    Debug.Log("Dropping: " + dropRandom);
                    StartCoroutine( DisableCollider());
                    Instantiate(people, collision.gameObject.transform.position, Quaternion.identity);
                    

                }
                bus.SetBusCapcity(bus.busCapcity - dropRandom);
            }
            else
                Debug.Log("no one want to drop");
        }
    }
    IEnumerator DisableCollider()
    {
        Debug.Log("stopping");
        GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(8f);
        GetComponent<BoxCollider>().enabled = true;

    }
}
