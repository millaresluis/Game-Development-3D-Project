using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock_Control : MonoBehaviour
{

    //required game objects
    private int[] result, correctCombination;
    public Transform doorHinge;
    public bool doorOpen;
    public GameObject Padlock;
    public GameObject Padlock_Collider;
    public GameObject TestObject;
    

    
    //object value initiation
    private void Start()
    {
        result = new int[]{0,0,0,0};
        correctCombination = new int[] {1,2,3,4};
        Rotate.Rotated += CheckResults;

    }


    //code value checking
    private void CheckResults(string wheelName, int number)
    {
        switch (wheelName)
        {
            case "WheelOne":
                result[0] = number;
                break;

            case "WheelTwo":
                result[1] = number;
                break;

            case "WheelThree":
                result[2] = number;
                break;

            case "WheelFour":
                result[3] = number;
                break;
        }

        if (result[0] == correctCombination[0] && result[1] == correctCombination[1]
            && result[2] == correctCombination[2] && result[3] == correctCombination[3])
        {
            
            Debug.Log("opened");
            doorOpen = true;
            Destroy(TestObject);
        }
    }


    //condition if triggered
    void Update()
    {
        
        if (doorOpen)
        {

            
            var newRot = Quaternion.RotateTowards(doorHinge.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 250);
            doorHinge.rotation = newRot;
            Destroy(Padlock);
            Destroy(Padlock_Collider);
            
        }
        
    }
    private void OnDestroy()
    {
        Rotate.Rotated -= CheckResults;
    }
}
