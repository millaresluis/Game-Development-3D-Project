using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public bool onTrigger;
    public Transform target;
    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
        
    }

    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
        
    }

    //conditions if triggered
    void Update()
    {
        if (onTrigger)
        {
            player.transform.position = target.position;
            Destroy(gameObject);
        }
    }
}
