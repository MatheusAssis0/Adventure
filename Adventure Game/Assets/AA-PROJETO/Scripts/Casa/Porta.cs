using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    [SerializeField] private GameObject obj1, obj2;
    [SerializeField] private AudioSource porta;
    private TransicaoManager script;
    private GlobalVars script_;
    private bool podeInteragir;
    private void Start()
    {
        script = FindObjectOfType<TransicaoManager>();
        script_ = FindObjectOfType<GlobalVars>();
    }
    private void Update()
    {
        if(podeInteragir == true && script_.A != 1)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                porta.Play();
                script_.objtvCasa = 1;
                script_.T = 0;
                script.Vila();
            }
        }

        if(script_.objtvCasa == 1)
        {
            obj1.SetActive(false);
            obj2.SetActive(true);
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
