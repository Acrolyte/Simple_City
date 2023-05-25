using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockManager : MonoBehaviour
{
    public const int hours = 24, mins = 60;
    public float day = 30f;

    float time = 0, current = 0;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        current = time % day;
    }

    public float GetHour() => current * hours / day;

    public float GetMinute() => (current * hours * mins / day) % mins;


}
