using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    [SerializeField] private GameObject obj1, obj2;
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
        if(podeInteragir == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Destroy(obj1);
                obj2.SetActive(true);
                script_.T = 0;
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
