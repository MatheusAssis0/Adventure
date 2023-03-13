using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DialogoUnico2 : MonoBehaviour
{
    [SerializeField] private NPCConversation Dialogo1, Dialogo2;
    private bool interagiu;
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
                if (Input.GetKeyDown(KeyCode.E) && interagiu == false)
                {
                   ConversationManager.Instance.StartConversation(Dialogo1);
                   interagiu = true;
                }
                else if(Input.GetKeyDown(KeyCode.E) && interagiu == true)
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
