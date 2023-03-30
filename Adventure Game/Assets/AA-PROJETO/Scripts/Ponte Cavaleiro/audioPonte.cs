using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPonte : MonoBehaviour
{
    private SomAndandoTroll script;

    private void Start()
    {
        script = FindObjectOfType<SomAndandoTroll>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            script.naGrama = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            script.naGrama = true;
        }
    }
}
