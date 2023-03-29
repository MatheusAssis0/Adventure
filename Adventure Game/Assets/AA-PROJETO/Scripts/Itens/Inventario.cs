using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    [SerializeField] private GameObject[] itens;
    private GlobalVars script;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
    }

    private void Update()
    {
        if(script.itemFlor == true)
        {
            itens[0].SetActive(true);
        }
        else
        {
            itens[0].SetActive(false);
        }

        if(script.itemBruxa == true)
        {
            itens[1].SetActive(true);
        }
        else
        {
            itens[1].SetActive(false);
        }

        if (script.itemTroll == true)
        {
            itens[2].SetActive(true);
        }
        else
        {
            itens[2].SetActive(false);
        }
    }
}
