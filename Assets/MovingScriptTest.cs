using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScriptTest : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        transform.position += transform.forward * 1f * Time.deltaTime;
    }
}
