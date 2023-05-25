using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalogClock : MonoBehaviour
{
    ClockManager cm;
    public Transform hourHand, minuteHand;

    const float hoursInDegs = 30, minsInDegs = 6;
    // Start is called before the first frame update
    void Start()
    {
        cm = FindObjectOfType<ClockManager>();
    }

    // Update is called once per frame
    void Update()
    {
        hourHand.rotation = Quaternion.Euler(0, 0, -cm.GetHour() * hoursInDegs);
        minuteHand.rotation = Quaternion.Euler(0, 0, -cm.GetMinute() * minsInDegs);
    }
}
