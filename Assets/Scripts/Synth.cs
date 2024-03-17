using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Synth : MonoBehaviour
{

    AudioSource source;

    private void Start()
    {
        source= GetComponent<AudioSource>();

        var clip = AudioClip.Create("Sin", 44100 * 3, 1, 44100, false);

        source.clip = clip;

        source.Play();
    }
}
