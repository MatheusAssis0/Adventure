using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colecionaveis : MonoBehaviour
{
    [SerializeField] private GameObject[] itensColecionaveis;
    private GlobalVars script;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
    }

    private void Update()
    {
        for (int i = 0; i < 8; i++)
        {
            if (script.colecionaveis == i)
            {
                itensColecionaveis[i].SetActive(true);
            }
        }

        if (script.colecionaveis == -1f)
        {
            foreach (GameObject obj in itensColecionaveis)
            {
                obj.SetActive(false);
            }
        }
    }
}
