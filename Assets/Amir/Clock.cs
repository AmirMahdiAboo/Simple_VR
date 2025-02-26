using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.iOS;

public class Clock : MonoBehaviour
{
    [SerializeField] private GameObject _hoursPointer;
    [SerializeField] private GameObject _minutesPointer;
    [SerializeField] private GameObject _secondsPointer;

    private int _currentHour;
    private int _currentMinutes;
    private int _currentSeconds;


    private void Update()
    {
        ExtractTimeFromDateTime(DateTime.Now);
        UpdateClockPointers();
    }


    private void ExtractTimeFromDateTime(DateTime dateTime)
    {
        _currentHour = dateTime.Hour;
        _currentMinutes = dateTime.Minute;
        _currentSeconds = dateTime.Second;
    }

    private void UpdateClockPointers()
    {
        float hoursRotation = (_currentHour % 12) * 30f + _currentMinutes * 0.5f; // 360 degrees / 12 hours = 30 degrees per hour
        float minutesRotation = _currentMinutes * 6f; // 360 degrees / 60 minutes = 6 degrees per minute
        float secondsRotation = _currentSeconds * 6f; // 360 degrees / 60 seconds = 6 degrees per second

        _hoursPointer.transform.localRotation= Quaternion.Euler(hoursRotation, 0f, 0f);
        _minutesPointer.transform.localRotation = Quaternion.Euler(minutesRotation, 0f, 0f);
        _secondsPointer.transform.localRotation = Quaternion.Euler(secondsRotation, 0f, 0f);
    }

}
