using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicmanager : MonoBehaviour
{
    public Slider slider;
    public AudioClip clip;
    public AudioSource audio;
    public float volume;

    private void Update()
    {
        audio.volume = slider.value;
    }
}

