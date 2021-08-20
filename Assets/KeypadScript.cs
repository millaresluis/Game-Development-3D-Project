using UnityEngine;
using System.Collections;
 
public class KeypadScript : MonoBehaviour
{

    public string curPassword = "12345";
    public string input;
    public bool onTrigger;
    public bool doorOpen;
    public bool keypadScreen;
    public Transform doorHinge;
    


    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
        keypadScreen = false;
        input = "";
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (input == curPassword)
        {
            doorOpen = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (doorOpen)
        {
            
            var newRot = Quaternion.RotateTowards(doorHinge.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 250);
            doorHinge.rotation = newRot;
        }
    }

    void OnGUI()
    {
        GUIStyle myButtonStyle = new GUIStyle(GUI.skin.button);
        myButtonStyle.fontSize = 35;
        if (!doorOpen)
        {
            if (onTrigger)
            {
                GUI.Box(new Rect(0, 0, 350, 55), "Press 'E' to open keypad");

                if (Input.GetKeyDown(KeyCode.E))
                {
                    keypadScreen = true;
                    onTrigger = false;
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                }
            }

            if (keypadScreen)
            {
                GUI.Box(new Rect(445, 45, 370, 545), "", myButtonStyle);
                GUI.Box(new Rect(465, 70, 330, 40), input, myButtonStyle);
                
                if (GUI.Button(new Rect(465, 125, 100, 100), "1", myButtonStyle))
                {
          
                    input = input + "1";

                    
                    
                }

                if (GUI.Button(new Rect(580, 125, 100, 100), "2", myButtonStyle))
                {
                    input = input + "2";
                }

                if (GUI.Button(new Rect(695, 125, 100, 100), "3", myButtonStyle))
                {
                    input = input + "3";
                }

                if (GUI.Button(new Rect(465, 240, 100, 100), "4", myButtonStyle))
                {
                    input = input + "4";
                }

                if (GUI.Button(new Rect(580, 240, 100, 100), "5", myButtonStyle))
                {
                    input = input + "5";
                }

                if (GUI.Button(new Rect(695, 240, 100, 100), "6", myButtonStyle))
                {
                    input = input + "6";
                }

                if (GUI.Button(new Rect(465, 355, 100, 100), "7", myButtonStyle))
                {
                    input = input + "7";
                }

                if (GUI.Button(new Rect(580, 355, 100, 100), "8", myButtonStyle))
                {
                    input = input + "8";
                }

                if (GUI.Button(new Rect(695, 355, 100, 100), "9", myButtonStyle))
                {
                    input = input + "9";
                }

                if (GUI.Button(new Rect(640, 470, 100, 100), "0", myButtonStyle))
                {
                    input = input + "0";
                }
                if (GUI.Button(new Rect(520, 470, 100, 100), "C", myButtonStyle))
                {
                    input = "";
                }
            }
        }
    }
}