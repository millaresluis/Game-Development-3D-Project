using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScareScript7 : MonoBehaviour
{
    public AudioSource Hit_stress;
    public GameObject ThePlayer;
    public GameObject JumpCam;


    void OnTriggerEnter()
    {
        Hit_stress.Play();
        JumpCam.SetActive(true);
        ThePlayer.SetActive(false);
        StartCoroutine(EndJump());


    }
    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(4f);
        ThePlayer.SetActive(true);
        JumpCam.SetActive(false);
        Destroy(gameObject);
    }
}
