using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasaC : MonoBehaviour
{
    private Transicao script;
    private GlobalVars script_;
    private bool podeInteragir;

    private void Start()
    {
        script = FindObjectOfType<Transicao>();
        script_ = FindObjectOfType<GlobalVars>();
    }
    private void Update()
    {
        if(podeInteragir == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                script_.A = 1;
                script.Transition("Casa");
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
