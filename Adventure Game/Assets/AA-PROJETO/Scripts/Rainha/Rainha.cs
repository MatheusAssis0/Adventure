using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainha : MonoBehaviour
{
    [SerializeField] private GameObject textoFim, canvasFim;

    private void Update()
    {
        if(canvasFim.activeSelf == true)
        {
            Invoke("LigaTexto", 1f);
        }
    }

    private void LigaTexto()
    {
        textoFim.SetActive(true);
    }
}
