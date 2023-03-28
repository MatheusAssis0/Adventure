using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DialogoPlaca : MonoBehaviour
{
    [SerializeField] private NPCConversation dialogo1, dialogoSemTroll, dialogoSemBruxa, dialogo2;
    private bool podeInteragir;
    private GlobalVars script;

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
                if (script.enigmaTroll == 2)
                {
                    ConversationManager.Instance.StartConversation(dialogoSemTroll);
                }
                if (script.enigmaBruxa == 2)
                {
                    ConversationManager.Instance.StartConversation(dialogoSemBruxa);
                }
                if (script.enigmaBruxa == 2 && script.enigmaTroll == 2)
                {
                    ConversationManager.Instance.StartConversation(dialogo2);
                }
                else
                {
                    ConversationManager.Instance.StartConversation(dialogo1);
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
