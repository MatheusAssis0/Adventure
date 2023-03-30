using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class SomAndandoTroll : MonoBehaviour
{
    private Vector3 previousPosition;
    [SerializeField] private AudioSource grama, madeira;
    private PlayerMovement script;
    public bool naGrama = true;

    void Start()
    {
        script = FindObjectOfType<PlayerMovement>();
        previousPosition = transform.position;
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
                if (!grama.isPlaying && naGrama == true)
                {
                    grama.Play();
                    madeira.Pause();
                }
                if (!madeira.isPlaying && naGrama == false)
                {
                    madeira.Play();
                    grama.Pause();
                }
            }
            else
            {
                if (grama.isPlaying)
                {
                    grama.Pause();
                }
                if (madeira.isPlaying)
                {
                    madeira.Pause();
                }
            }
        }

        previousPosition = transform.position;
    }
}
