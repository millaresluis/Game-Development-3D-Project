using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book_Interact : MonoBehaviour
{

    //required game objects
    public bool obtain = false;
    public bool inTrigger = false;
    public GameObject book;
    public GameObject text;
    
    

    // condition if triggered
    void Update()
    {
        if (inTrigger == true && Input.GetKey(KeyCode.E))
        {
            book.SetActive(false);
            obtain = true;
            text.SetActive(false);
            Destroy(gameObject);
        }
    }

    //trigger function
    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
        text.SetActive(true);
    }
    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
        text.SetActive(false);
    }
}
