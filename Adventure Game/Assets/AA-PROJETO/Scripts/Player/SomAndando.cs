using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class SomAndando : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private AudioSource audioSource;
    private PlayerMovement script;
    private GlobalVars script_;

    void Start()
    {
        script = FindObjectOfType<PlayerMovement>();
        script_ = FindObjectOfType<GlobalVars>();
        audioSource = GetComponentInChildren<AudioSource>();
    }

    private void Update()
    {
        if (ConversationManager.Instance != null && ConversationManager.Instance.IsConversationActive || script_.isPaused == true)
        {
            audioSource.Pause();
            return;
        }
        else
        {
            if(rb.velocity.x != 0 && script.IsGrounded())
            {
                if (!audioSource.isPlaying)
                {
                    audioSource.Play();
                }
            }
            else
            {
                audioSource.Stop();
            }
        }
    }
}
