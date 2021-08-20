using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScareScript2 : MonoBehaviour
{
    public AudioSource Hit_stress;
    public GameObject EnemyObject;


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
