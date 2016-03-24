using System;
using System.Collections;
using UnityEngine;

public class ChristmasKebab : MonoBehaviour
{
    public AudioClip ChristmasMusic;

    public bool test;

    [HideInInspector]
    public bool isChristmas { get; private set; }

    // Use this for initialization
    public void Start()
    {
        DateTime date = DateTime.Today;
        int Day = date.Day;
        int Month = date.Month;
        if (Month == 12 || test)
        {
            if (Day == 24 || Day == 25 || Day == 26 || test)
            {
                isChristmas = true;
                GetComponent<AudioSource>().clip = ChristmasMusic;
                GetComponent<AudioSource>().Play();
            }
        }
    }
}