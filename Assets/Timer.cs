using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    float timer = 30f;
    float twotimer = 30f;
    public int Turn;

    // Update is called once per frame
    void Update()
    {
        if (Turn == 1)
        {
            timer = Time.deltaTime;
        }
        else
        {
            twotimer = Time.deltaTime;
        }
    }
}
