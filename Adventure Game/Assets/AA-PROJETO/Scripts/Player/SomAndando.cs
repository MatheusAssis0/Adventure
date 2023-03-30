using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class SomAndando : MonoBehaviour
{
    private Vector3 previousPosition;
    private AudioSource audioSource;
    private PlayerMovement script;

    void Start()
    {
        script = FindObjectOfType<PlayerMovement>();
        previousPosition = transform.position;
        audioSource = GetComponentInChildren<AudioSource>();
    }

    void Update()
    {
        if (ConversationManager.Instance != null && ConversationManager.Instance.IsConversationActive)
        {
            return;
        }
        else
        {
            if (transform.position != previousPosition && script.IsGrounded())
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
        }

        previousPosition = transform.position;
    }
}
