using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInteract : MonoBehaviour
{
    
    public GameObject NoteImg;


    void OnTriggerEnter()
    {

        NoteImg.SetActive(true);
        


    }
    void OnTriggerExit(Collider other)
    {
        NoteImg.SetActive(false);
    }
     
        
        
    
}
