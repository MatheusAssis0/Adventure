using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioMadeira : MonoBehaviour
{
    private SomAndandoFloresta script;

    private void Start()
    {
        script = FindObjectOfType<SomAndandoFloresta>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            script.naGrama = false;
            script.naPedra = false;
            script.naPlataforma = true;
        }
    }
}
