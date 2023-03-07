using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    private TransicaoManager script;
    private bool podeInteragir;
    private void Start()
    {
        script = FindObjectOfType<TransicaoManager>();
    }
    private void Update()
    {
        if(podeInteragir == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                script.Vila();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            podeInteragir = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            podeInteragir = false;
        }
    }
}
