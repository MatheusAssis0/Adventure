using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Test : MonoBehaviour
{
    [SerializeField] private NPCConversation teste;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if (ConversationManager.Instance != null && ConversationManager.Instance.IsConversationActive)
            {
                return;
            }
            ConversationManager.Instance.StartConversation(teste); 
        }
    }
}
