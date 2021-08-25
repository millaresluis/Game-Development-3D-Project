using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject text;
    public bool status = false;
    public GameObject switch0;
    public GameObject switch1;
    public GameObject switch2;
    public GameObject switch3;
    public GameObject jumpscareOff;
    public bool inTrigger;

    void OnTriggerEnter(Collider other) { 

        inTrigger = true;
        text.SetActive(true);


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
