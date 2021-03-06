using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookshelfMove : MonoBehaviour
{

    //required game objects
    public GameObject movingDoor;
    public float maximumOpening = 20f;
    public Book_Interact obtain;
    public float movementSpeed = 5f;
    public GameObject Text;
    public GameObject Missing;
    bool playerIsHere;

    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
        
    }

    // condition if triggered
    void Update()
    {
        if (playerIsHere && obtain.obtain == true)
        {
            if (movingDoor.transform.position.x < maximumOpening)
            {
                Missing.SetActive(false);
                movingDoor.transform.Translate(0f, 0f, movementSpeed * Time.deltaTime);
                Debug.Log("moved");
                Destroy(gameObject, .8f);
            }
        }

        
        


    }


    //trigger function
    private void OnTriggerEnter()
    {
        if (playerIsHere == true && obtain.obtain == false) ;
        {
            Debug.Log("test");
            Missing.SetActive(true);
        }
        playerIsHere = true;
        
    }

    private void OnTriggerExit()
    {
        Missing.SetActive(false);
        playerIsHere = false;
        
    }



}