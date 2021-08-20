using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RiddleInput : MonoBehaviour
{
    public string input;
    public string answer = "hello";
    public GameObject inputText;
    public GameObject inputField;
    public GameObject textDisplay;
    public GameObject button;
    public GameObject note;
    public GameObject RiddleCollider;
    public InputField inputFieldRef;
    public bool doorOpen;
    public Transform doorHinge;
    

    public void StoreName()
    {
        
        input = inputText.GetComponent<Text>().text;

        if (input == answer)
        {
            textDisplay.GetComponent<Text>().text = "lezgo";
            Destroy(inputText);
            Destroy(inputField);
            Destroy(textDisplay);
            Destroy(button);
            Destroy(note);
            Destroy(RiddleCollider);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            doorOpen = true;
            

        }

        else
        {
            textDisplay.GetComponent<Text>().text = "incorrect";
            inputFieldRef.text = "";
        }

    
}
    void Update()
    {

        if (doorOpen)
        {
            var newRot = Quaternion.RotateTowards(doorHinge.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 250);
            doorHinge.rotation = newRot;
        }
    }
    

}
