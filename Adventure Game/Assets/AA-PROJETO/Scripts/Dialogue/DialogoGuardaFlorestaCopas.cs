using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DialogoGuardaFlorestaCopas : MonoBehaviour
{
    [SerializeField] private NPCConversation dialogo1, dialogo2, dialogo3;
    private bool podeInteragir, interagiu, jaInteragiu;
    private GlobalVars script;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
    }

    private void Update()
    {
        if (ConversationManager.Instance != null && ConversationManager.Instance.IsConversationActive || jaInteragiu == true)
        {
            return;
        }
        else
        {
            if (podeInteragir == true)
            {
                if (script.enigmaBruxa >= 1 && script.enigmaTroll >= 1 && Input.GetKeyDown(KeyCode.E))
                {
                    ConversationManager.Instance.StartConversation(dialogo3);
                }
                else if (Input.GetKeyDown(KeyCode.E) && interagiu == false)
                {
                    ConversationManager.Instance.StartConversation(dialogo1);
                    interagiu = true;
                }
                else if (Input.GetKeyDown(KeyCode.E) && interagiu == true)
                {
                    ConversationManager.Instance.StartConversation(dialogo2);
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

    public void FimEnigma()
    {
        jaInteragiu = true;
    }
}
