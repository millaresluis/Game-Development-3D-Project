using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScareScript6 : MonoBehaviour
{

    public GameObject jumpscareObject;
    public GameObject lightObject;
    public GameObject lightObject2;
    public AudioSource Hit_stress;
    
    void Start()
    {
        lightObject.SetActive(false);
        lightObject2.SetActive(false);
        jumpscareObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {

        lightObject.SetActive(true);
        lightObject2.SetActive(true);
        jumpscareObject.SetActive(true);
        StartCoroutine(DestroyObject());
        
    }
    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(2f);
        Destroy(jumpscareObject);
        Destroy(lightObject);
        Destroy(lightObject2);
        Destroy(gameObject);
        Hit_stress.Play();
    }
}