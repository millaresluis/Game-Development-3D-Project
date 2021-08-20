using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookInteract : MonoBehaviour
{
    public bool obtain = false;
    public bool inTrigger = false;
    public GameObject book;
    public GameObject text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
