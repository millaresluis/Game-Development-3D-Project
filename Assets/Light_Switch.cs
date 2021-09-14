using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Switch : MonoBehaviour
{
    public GameObject text;
    public bool status = false;
    public GameObject switch0;
    public GameObject switch1;
    public GameObject switch2;
    public GameObject switch3;
    public GameObject jumpscareOff;
    public bool inTrigger;


    //trigger function
    void OnTriggerEnter(Collider other) { 

        inTrigger = true;
        text.SetActive(true);
    }

    // conditions if triggered
    void Update()
    {
        if (switch0.active == true)
        {
            status = true;
        }
        else
        {
            status = false;
        }

        if (inTrigger)
        {
            if (status)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    jumpscareOff.SetActive(true);
                    switch0.active = false;
                    switch1.active = false;
                    switch2.active = false;
                    switch3.active = false;
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    switch0.active = true;
                    switch1.active = true;
                    switch2.active = true;
                    switch3.active = true;
                }
            }
        }
        
        
        
    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
        text.SetActive(false);

    }
}
