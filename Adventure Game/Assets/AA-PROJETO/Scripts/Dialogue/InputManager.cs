using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class InputManager : MonoBehaviour
{
    private void Update()
    {
        if(ConversationManager.Instance != null && ConversationManager.Instance.IsConversationActive)
        {
            if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                ConversationManager.Instance.SelectPreviousOption();
            }
            
            if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            {
                ConversationManager.Instance.SelectNextOption();
            }

            if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                ConversationManager.Instance.PressSelectedOption();
            }
        }
    }
}
