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
        for (int i = 0; i < 8; i++)
        {
            if (script.itens == i)
            {
                itens[i].SetActive(true);
            }
        }

        if (script.itens == -1f)
        {
            foreach (GameObject obj in itens)
            {
                obj.SetActive(false);
            }
        }
    }
}
