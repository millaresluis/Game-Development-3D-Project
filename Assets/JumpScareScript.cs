using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScareScript : MonoBehaviour
{
    public AudioSource Hit_stress;
    public GameObject ThePlayer;
    public GameObject JumpCam;
    public GameObject FlashImg;
    

    void OnTriggerEnter()
    {
        Hit_stress.Play();
        JumpCam.SetActive(true);
        ThePlayer.SetActive(false);
        FlashImg.SetActive(true);
        StartCoroutine(EndJump());

        
    }
    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(4f);
        ThePlayer.SetActive(true);
        JumpCam.SetActive(false);
        FlashImg.SetActive(false);
        Destroy(gameObject);
    }
}
