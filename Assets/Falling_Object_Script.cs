using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_Object_Script : MonoBehaviour
{

    //required game objects
    public GameObject box;
    public GameObject sphereTrigger;
    public AudioSource Hit_stress;


    //trigger function
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        Hit_stress.Play();
        sphereTrigger.SetActive(true);
        StartCoroutine(DeactivateSphere());
    }

    IEnumerator DeactivateSphere()
    {
        
        yield return new WaitForSeconds(0.5f);
        sphereTrigger.SetActive(false);
        
    }
}
