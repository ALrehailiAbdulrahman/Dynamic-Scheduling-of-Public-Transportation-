using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;

    public Canvas can1;
    public Canvas can2;
    public Canvas can3;
    public Canvas can4;

    // Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(true);

        can1.enabled = false;
        can2.enabled = false;
        can3.enabled = false;
        can4.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);

            can1.enabled = true;
            can2.enabled = false;
            can3.enabled = false;
            can4.enabled = false;


        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
            cam4.SetActive(false);

            can1.enabled = false;
            can2.enabled = true;
            can3.enabled = false;
            can4.enabled = false;

        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
            cam4.SetActive(false);

            can1.enabled = false;
            can2.enabled = false;
            can3.enabled = true;
            can4.enabled = false;


        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(true);

            can1.enabled = false;
            can2.enabled = false;
            can3.enabled = false;
            can4.enabled = true;




        }
    }
}
