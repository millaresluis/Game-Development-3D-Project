using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScareScript5 : MonoBehaviour
{
    public GameObject chair;
    public GameObject sphereTrigger;
    public AudioSource Hit_stress;

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
