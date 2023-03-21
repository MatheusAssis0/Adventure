using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DialogoPlayerPos : MonoBehaviour
{
    [SerializeField] private Transform npc;
    private PlayerMovement script;

    private void Start()
    {
        script = FindObjectOfType<PlayerMovement>();
    }
    public void playerDireita()
    {
        Vector3 localScale = script.player.transform.localScale;
        localScale.x *= -1f;
        script.player.transform.localScale = localScale;
        script.isFacingRight = false;

        Vector3 localPos = script.player.transform.localPosition;
        localPos.x = npc.transform.position.x + 1.1f;
        script.player.transform.position = localPos;
    }

    public void playerEsquerda()
    {
        Vector3 localScale = script.player.transform.localScale;
        localScale.x = 1f;
        script.player.transform.localScale = localScale;
        script.isFacingRight = true;

        Vector3 localPos = script.player.transform.localPosition;
        localPos.x = npc.transform.position.x - 1.1f;
        script.player.transform.position = localPos;
    }
}
