using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoManDoor : MonoBehaviour
{
    public bool onTrigger;
    public Transform doorHinge;
    public GameObject text;

    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
        text.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
        text.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && onTrigger == true)
        {
            Debug.Log("done");
            var newRot = Quaternion.RotateTowards(doorHinge.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 150);
            doorHinge.rotation = newRot;
        }

        else 
        {
            var newRot = Quaternion.RotateTowards(doorHinge.rotation, Quaternion.Euler(0.0f, 0f, 0.0f), Time.deltaTime * 250);
            doorHinge.rotation = newRot;
        }
    }
}
