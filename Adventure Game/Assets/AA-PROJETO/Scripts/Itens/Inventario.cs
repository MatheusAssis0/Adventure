using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

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
        for (int i = 0; i < 8; i++)
        {
            if (script.itens == i)
            {
                itens[i].SetActive(true);
            }
        }
    }
}
