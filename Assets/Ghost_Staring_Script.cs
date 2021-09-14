using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_Staring_Script : MonoBehaviour
{
    //required game objects
    public AudioSource Hit_stress;
    public GameObject EnemyObject;



    //trigger function
    void OnTriggerEnter()
    {
        Hit_stress.Play();
        EnemyObject.SetActive(true);
        StartCoroutine(EndJump());


    }
    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(5f);
        EnemyObject.SetActive(false);
        Destroy(gameObject);
    }
}
