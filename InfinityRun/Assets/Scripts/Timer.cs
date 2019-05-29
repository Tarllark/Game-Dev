using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float time;
    private int seconds;
    private int minutes;
    private int hours;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        seconds = (int)(time % 60);
        minutes = (int)(time / 60);
        hours = (int)(time / 3600);

        gameObject.GetComponent<Text>().text = string.Format("{0:0}:{1:00}:{2:00}", hours, minutes, seconds);
    }
}
