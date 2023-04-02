using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DialogoRainha : MonoBehaviour
{
    [SerializeField] private NPCConversation Dialogo1, Dialogo2;
    private GlobalVars script;
    private bool podeInteragir;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
    }

    private void Update()
    {
        if (ConversationManager.Instance != null && ConversationManager.Instance.IsConversationActive)
        {
            return;
        }
        else
        {
            if (podeInteragir == true)
            {
                if (Input.GetKeyDown(KeyCode.E) && script.colecionavelPena == true && script.colecionavelVeludo == true)
                {
                    ConversationManager.Instance.StartConversation(Dialogo1);
                }
                else if (Input.GetKeyDown(KeyCode.E))
                {
                    ConversationManager.Instance.StartConversation(Dialogo2);
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            podeInteragir = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            podeInteragir = false;
        }
    }
}

