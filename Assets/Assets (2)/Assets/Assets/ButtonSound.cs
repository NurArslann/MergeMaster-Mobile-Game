using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public static AudioSource button;

    void Start()
    {
        button = GetComponent<AudioSource>();
    }

    void Update()
    {
    }

    public static void play()
    {
        button.Play();
    }

}