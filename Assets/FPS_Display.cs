using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPS_Display : MonoBehaviour
{
    public TextMeshProUGUI FpsText;
    public float pollingTime = 1f;
    public float time;
    public int frameCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        frameCount++;

        if(time >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(frameCount / time);
            FpsText.text =   "Client FPS: " + frameRate.ToString();

            time -= pollingTime;
            frameCount = 0;
        }
    }
}
