using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasaC : MonoBehaviour
{
    private GameObject coronel_;
    private Transicao script;
    private bool podeInteragir;

    private void Start()
    {
        script = FindObjectOfType<Transicao>();
    }
    private void Update()
    {
        if(podeInteragir == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                script.Transition("Casa");
                Invoke("coronel", 1.1f);
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
    private void coronel()
    {
        coronel_ = GameObject.FindGameObjectWithTag("Coronel");
        coronel_.SetActive(true);
    }
}
