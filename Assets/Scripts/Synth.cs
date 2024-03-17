using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Synth : MonoBehaviour
{

    AudioSource source;
    public float frequency = 50f;

    private void Start()
    {
        source= GetComponent<AudioSource>();

        var clip = AudioClip.Create("Sin", 44100 * 3, 1, 44100, false);

        var samples = new float[44100 * 3];
        for (int i = 0; i < samples.Length; i++)
        {
            samples[i] = Mathf.Sin(i / 44100f * 6.28f * frequency);
        }

        clip.SetData(samples, 0);

        source.clip = clip;
        source.Play();
    }
}
