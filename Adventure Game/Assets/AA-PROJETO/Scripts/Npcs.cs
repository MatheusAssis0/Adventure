using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Npcs : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator anim;
    [SerializeField] private float speed;
    [SerializeField] private float patrolRange;
    [SerializeField] private float tempoDeEspera = 5f;
    private PlayerMovement script;
    private Vector2 destino, velocity;
    private float proximaPatrulha = 0f;
    private float pivot;

    private void Start()
    {
        pivot = transform.position.x;   
        script = FindObjectOfType<PlayerMovement>();
    }
    IEnumerator Npc()
    {
        anim.SetBool("Andando", true);
        rb.velocity = new Vector2(speed, rb.velocity.y);

        yield return new WaitForSeconds(2f);

        anim.SetBool("Andando", false);
        rb.velocity = new Vector2(0, rb.velocity.y);
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;

        yield return new WaitForSeconds(5f);

        anim.SetBool("Andando", true);
        rb.velocity = new Vector2(-speed, rb.velocity.y);

        yield return new WaitForSeconds(2f);

        anim.SetBool("Andando", false);
        rb.velocity = new Vector2(0, rb.velocity.y);
        localScale.x = 1f;
        transform.localScale = localScale;

        yield return new WaitForSeconds(5f);

        StartCoroutine("Npc");
    }

    private void Update()
    {
        if(ConversationManager.Instance != null && ConversationManager.Instance.IsConversationActive)
        {
            velocity = Vector2.zero;
            TeleportaPlayer();
            anim.SetBool("Andando", false);
            return;
        }

        if(rb.velocity.x > 0 && transform.localScale.x < 0f || rb.velocity.x < 0 && transform.localScale.x > 0f)
        {
            Flip();
        }

        if(rb.velocity.x != 0)
        {
            anim.SetBool("Andando", true);
        }
        else
        {
            anim.SetBool("Andando", false);
        }

        if(Time.time >= proximaPatrulha)
        {
            destino = NovoDestino();
            proximaPatrulha = Time.time + tempoDeEspera;
        }

        float distance = Vector2.Distance(destino, transform.position);
        if(distance < 0.2f)
        {
            velocity = Vector2.zero;
        }
        else
        {
           Vector2 direcao = (destino - (Vector2)transform.position).normalized;
           velocity = direcao * speed;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = velocity;
    }
    private Vector2 NovoDestino()
    {
        return new Vector2(pivot + Random.Range(-patrolRange, patrolRange), transform.position.y);
    }

    private void Flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;  
    }

    private void TeleportaPlayer()
    {
        if(transform.localScale.x > 0)
        {
            Vector3 localScale = script.player.transform.localScale;
            localScale.x *= -1f;
            script.player.transform.localScale = localScale;
            script.isFacingRight = false;

            Vector3 localPos = script.player.transform.localPosition;
            localPos.x = transform.position.x + 1.1f;
            script.player.transform.position = localPos;
        }
        else
        {
            Vector3 localScale = script.player.transform.localScale;
            localScale.x = 1f;
            script.player.transform.localScale = localScale;
            script.isFacingRight = true;

            Vector3 localPos = script.player.transform.localPosition;
            localPos.x = transform.position.x - 1.1f;
            script.player.transform.position = localPos;
        }
    }
}

