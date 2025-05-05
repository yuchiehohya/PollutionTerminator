using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSound : MonoBehaviour
{
    AudioSource starAudio;
    // Start is called before the first frame update
    void Start()
    {
        starAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        PlaySound();
    }

    public void PlaySound()
    {
        if (enabled)
        {
            starAudio.Play();
        }
    }
}
