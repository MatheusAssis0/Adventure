using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparente : MonoBehaviour
{
    [SerializeField] private SpriteRenderer moita;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Color transparente = moita.color;
            transparente.a = 0.3f;
            moita.color = transparente;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Color transparente = moita.color;
            transparente.a = 1f;
            moita.color = transparente;
        }
    }
}
