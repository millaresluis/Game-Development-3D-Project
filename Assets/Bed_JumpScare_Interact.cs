using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed_JumpScare_Interact : MonoBehaviour
{
    public GameObject TestSelect;
    public GameObject Text;
    public bool inTrigger = false;


    void OnTriggerEnter(Collider other)
    {

        Debug.Log("done");
        inTrigger = true;
        Text.SetActive(true);
        Cursor.visible = true;
    }


    void Update()
    {
        if (inTrigger == true && Input.GetKeyDown(KeyCode.E))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Text.SetActive(false);
            TestSelect.SetActive(true);
            Destroy(TestSelect, 0.8f);
            Destroy(gameObject, 0.8f);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Text.SetActive(false);
            TestSelect.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            
        }




    }

    void OnTriggerExit(Collider other)
    {
        Text.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        inTrigger = false;
        TestSelect.SetActive(false);
        
    }
}
