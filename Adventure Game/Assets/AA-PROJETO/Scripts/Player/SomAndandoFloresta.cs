using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class SomAndandoFloresta : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private AudioSource grama, madeira, pedra;
    private PlayerMovement script;
    private GlobalVars script_;
    public bool naGrama, naPlataforma, naPedra;

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
            pedra.Pause();
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
                    pedra.Pause();
                }
                if (!madeira.isPlaying && naPlataforma == true)
                {
                    madeira.Play();
                    grama.Pause();
                    pedra.Pause();
                }
                if (!pedra.isPlaying && naPedra == true)
                {
                    pedra.Play();
                    grama.Pause();
                    madeira.Pause();
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
                if(pedra.isPlaying)
                {
                    pedra.Pause();
                }
            }
        }
    }
}
