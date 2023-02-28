using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DialogoUnico : MonoBehaviour
{
    [SerializeField] private NPCConversation Dialogo1;
    private bool podeInteragir;


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
                if (Input.GetKeyDown(KeyCode.E))
                {
                   ConversationManager.Instance.StartConversation(Dialogo1); 
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
