using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class SomAndandoTroll : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private AudioSource grama, madeira;
    private PlayerMovement script;
    private GlobalVars script_;
    public bool naGrama = true;

    void Start()
    {
        script = FindObjectOfType<PlayerMovement>();
        script_ = FindObjectOfType<GlobalVars>();
    }

    void Update()
    {
        if (ConversationManager.Instance != null && ConversationManager.Instance.IsConversationActive || script_.isPaused == true)
        {
            grama.Pause();
            madeira.Pause();
            return;
        }
        else
        {
            if (rb.velocity.x != 0 && script.IsGrounded())
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
    }
}
