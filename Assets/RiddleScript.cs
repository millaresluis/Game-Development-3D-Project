using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddleScript : MonoBehaviour
{
    public bool onTrigger;
    public GameObject keypadScreen;
    public string input;

    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
        keypadScreen.SetActive(true);
        input = "";
        Cursor.visible = false;

    }

    void OnGUI()
    {
        GUIStyle myButtonStyle = new GUIStyle(GUI.skin.button);
        myButtonStyle.fontSize = 40;
        if (onTrigger)
        {
            GUI.Box(new Rect(0, 0, 350, 55), "Press 'E' to open keypad");

            if (Input.GetKeyDown(KeyCode.E))
            {
                keypadScreen.SetActive(true);
                onTrigger = false;

            }
        }
    }
}
