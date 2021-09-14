using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Interact : MonoBehaviour
{
    public GameObject inputField;
    public GameObject button;
    public GameObject text;
    public GameObject note;
    public GameObject press;
    public bool inTrigger = false;
    

    void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("qwe");
        inTrigger = true;
        
        press.SetActive(true);
        
        
        

    }


    void Update()
    {
        if (inTrigger == true && Input.GetKeyDown(KeyCode.E))
        {
            press.SetActive(false);
            inputField.SetActive(true);
            button.SetActive(true);
            text.SetActive(true);
            note.SetActive(true);
            
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Debug.Log("done");
        }
        if (inTrigger == true && Input.GetKeyDown(KeyCode.Escape))
        {
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
        press.SetActive(false);
        inputField.SetActive(false);
        button.SetActive(false);
        text.SetActive(false);
        note.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
    }
    
}
