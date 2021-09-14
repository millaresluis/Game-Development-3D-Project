using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights_Off_Jumpscare : MonoBehaviour
{
    public AudioSource Hit_stress;
    public GameObject EnemyObject;
    public Light_Switch status;

    void OnTriggerEnter()
    {
        Hit_stress.Play();
        EnemyObject.SetActive(true);
        StartCoroutine(EndJump());


    }
    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(2f);
        EnemyObject.SetActive(false);
        Destroy(gameObject);
        
    }
}

