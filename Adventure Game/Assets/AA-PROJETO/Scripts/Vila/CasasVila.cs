using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasasVila : MonoBehaviour
{
    private Transicao script;
    private GlobalVars script_;
    private bool podeInteragir;
    public enum Opcoes { casa1, casa2 };
    public Opcoes opcoes;

    private void Start()
    {
        script = FindObjectOfType<Transicao>();
        script_ = FindObjectOfType<GlobalVars>();
    }
    private void Update()
    {
        switch(opcoes)
        {
            case (Opcoes.casa1):
                if (podeInteragir == true)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        script_.A = Random.Range(2,4);
                        script.Transition("Casa");
                    }
                }
                break;

            case (Opcoes.casa2):
                if (podeInteragir == true)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        script.Transition("Casa");
                    }
                }
                break;
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
