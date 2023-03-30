using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomAndando : MonoBehaviour
{
    private Vector3 previousPosition;
    private AudioSource audioSource;

    void Start()
    {
        previousPosition = transform.position;
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (transform.position != previousPosition)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Pause();
            }
        }

        previousPosition = transform.position;
    }
}
