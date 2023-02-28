using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DialogoUnicoColisao : MonoBehaviour
{
    [SerializeField] private NPCConversation Dialogo;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if (ConversationManager.Instance != null && ConversationManager.Instance.IsConversationActive)
            {
                return;
            }
            ConversationManager.Instance.StartConversation(Dialogo);
        }
    }
}
