using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioGrama : MonoBehaviour
{
    private SomAndandoFloresta script;

    private void Start()
    {
        script = FindObjectOfType<SomAndandoFloresta>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            script.naGrama = true;
            script.naPedra = false;
            script.naPlataforma = false;
        }
    }
}
