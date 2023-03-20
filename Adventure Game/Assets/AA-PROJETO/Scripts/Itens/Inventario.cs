using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    [SerializeField] private GameObject[] itemX;
    [SerializeField] private GameObject[] itemQ;
    private GlobalVars script;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            ChecarItensX();
            ChecarItensQ();
        }

        /*for (int i = 0; i < 3; i++)
        {
            if (script.itemX == i)
            {
                itemX[i].SetActive(true);
            }
        }
        for (int i = 0; i < 4; i++)
        {
            if (script.itemQ == i)
            {
                itemQ[i].SetActive(true);
            }
        }*/
    }

    private void ChecarItensX()
    {
        for (int i = 0; i < 3; i++)
        {
            if (script.itemX == i)
            {
                itemX[i].SetActive(true);
            }
        }
    }

    private void ChecarItensQ()
    {
        for (int i = 0; i < 4; i++)
        {
            if (script.itemQ == i)
            {
                itemQ[i].SetActive(true);
            }
        }
    }
}
