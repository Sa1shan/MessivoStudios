using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject objectToDisable;
    public GameObject objectToEnable;
    public AudioSource audioSourceToEnable;

    private void addvoice()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.enabled = true;
    }
    private void OnMouseDown()
    {
        objectToDisable.SetActive(false);
        objectToEnable.SetActive(true);
        audioSourceToEnable.enabled = true;
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.enabled = true;
    }
}
