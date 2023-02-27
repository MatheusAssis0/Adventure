using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DialogoRandom : MonoBehaviour
{
    [SerializeField] private NPCConversation Dialogo1, Dialogo2;
    private bool podeInteragir;
    public int dialogo;


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
                    dialogo = Random.Range(1, 3);
                    if (dialogo == 1)
                    {
                        ConversationManager.Instance.StartConversation(Dialogo1);
                    }
                    else
                    {
                        ConversationManager.Instance.StartConversation(Dialogo2);
                    }
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
