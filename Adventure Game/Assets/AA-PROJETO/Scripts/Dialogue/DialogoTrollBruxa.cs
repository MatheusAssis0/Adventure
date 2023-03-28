using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoTrollBruxa : MonoBehaviour
{
    [SerializeField] private NPCConversation dialogo1, dialogo2, dialogo3; 
    public enum Opcoes { bruxa, troll, outrosBruxa, outrosTroll, florestaCopas, guardaFinal, castelo}
    public Opcoes opcoes;
    private GlobalVars script;
    private bool podeInteragir;
    private int dialogo;

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

        switch (opcoes)
        {
            case Opcoes.bruxa:
                if (podeInteragir == true && Input.GetKeyDown(KeyCode.E))
                {
                    if (script.enigmaBruxa == 0 && script.enigmaTroll == 0)
                    {
                        ConversationManager.Instance.StartConversation(dialogo1);
                    }
                    if (script.enigmaBruxa == 0 && script.enigmaTroll == 1)
                    {
                        ConversationManager.Instance.StartConversation(dialogo2);
                    }
                    if (script.enigmaBruxa == 1)
                    {
                        ConversationManager.Instance.StartConversation(dialogo3);
                    }
                }
                break;
            case Opcoes.troll:
                if (podeInteragir == true && Input.GetKeyDown(KeyCode.E))
                {
                    if (script.enigmaBruxa == 0 && script.enigmaTroll == 0)
                    {
                        ConversationManager.Instance.StartConversation(dialogo1);
                    }
                    if (script.enigmaBruxa == 1 && script.enigmaTroll == 0)
                    {
                        ConversationManager.Instance.StartConversation(dialogo2);
                    }
                    if (script.enigmaTroll == 1)
                    {
                        ConversationManager.Instance.StartConversation(dialogo3);
                    }
                }
                break;
            case Opcoes.outrosBruxa:
                if (podeInteragir == true && Input.GetKeyDown(KeyCode.E))
                {
                    if (script.enigmaBruxa == 0)
                    {
                        ConversationManager.Instance.StartConversation(dialogo1);
                    }
                    if (script.enigmaBruxa == 1)
                    {
                        dialogo = Random.Range(1, 3);
                        if (dialogo == 1)
                        {
                            ConversationManager.Instance.StartConversation(dialogo2);
                        }
                        if(dialogo== 2)
                        {
                            ConversationManager.Instance.StartConversation(dialogo3);
                        }
                    }
                }
                break;
            case Opcoes.outrosTroll:
                if (podeInteragir == true && Input.GetKeyDown(KeyCode.E))
                {
                    if (script.enigmaTroll == 0)
                    {
                        ConversationManager.Instance.StartConversation(dialogo1);
                    }
                    if (script.enigmaTroll == 1)
                    {
                        dialogo = Random.Range(1, 3);
                        if (dialogo == 1)
                        {
                            ConversationManager.Instance.StartConversation(dialogo2);
                        }
                        if (dialogo == 2)
                        {
                            ConversationManager.Instance.StartConversation(dialogo3);
                        }
                    }
                }
                break;
            case Opcoes.florestaCopas:
                if (podeInteragir == true && Input.GetKeyDown(KeyCode.E))
                {
                    if (script.enigmaTroll == 0 || script.enigmaBruxa == 0)
                    {
                        dialogo= Random.Range(1, 3);
                        if (dialogo == 1)
                        {
                            ConversationManager.Instance.StartConversation(dialogo1);
                        }
                        if(dialogo == 2)
                        {
                            ConversationManager.Instance.StartConversation(dialogo2);
                        }
                    }
                    if (script.enigmaTroll == 2 && script.enigmaBruxa == 2)
                    {
                        ConversationManager.Instance.StartConversation(dialogo3);
                    }
                }
                break;
            case Opcoes.guardaFinal:
                if (podeInteragir == true && Input.GetKeyDown(KeyCode.E))
                {
                    if(script.enigmaBruxa == 1 && script.enigmaTroll == 1)
                    {
                        ConversationManager.Instance.StartConversation(dialogo1);
                    }
                }
                break;
            case Opcoes.castelo:
                if (podeInteragir == true && Input.GetKeyDown(KeyCode.E))
                {
                    if(script.enigmaGuardaFloresta == true)
                    {
                        ConversationManager.Instance.StartConversation(dialogo3);
                    }
                    else
                    {
                        dialogo = Random.Range(1, 3);
                        if(dialogo == 1)
                        {
                            ConversationManager.Instance.StartConversation(dialogo1);
                        }
                        if(dialogo == 2)
                        {
                            ConversationManager.Instance.StartConversation(dialogo2);
                        }
                    }
                }
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            podeInteragir= true;    
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
