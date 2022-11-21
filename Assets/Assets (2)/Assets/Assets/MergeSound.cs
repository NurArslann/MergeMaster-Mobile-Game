using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeSound : MonoBehaviour
{
    public static AudioSource merge;

    void Start()
    {
        merge = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    public static void play()
    {
        merge.Play();
    }

}