using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarradorVila : MonoBehaviour
{
    [SerializeField] private GameObject texto1, texto2, texto3, texto4, canvas;
    private GlobalVars script;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
        if(script.introVila == 1)
        {
            canvas.SetActive(false);
        }
        Invoke("Texto2", 5f);
        Invoke("Texto3", 10f);
        Invoke("Texto4", 15f);
        Invoke("Fim", 20f);
    }

    private void Texto2()
    {
        texto1.SetActive(false);
        texto2.SetActive(true);
    }

    private void Texto3()
    {
        texto2.SetActive(false);
        texto3.SetActive(true);
    }

    private void Texto4()
    {
        texto3.SetActive(false);
        texto4.SetActive(true);
    }

    private void Fim()
    {
        texto4.SetActive(false);
        canvas.SetActive(false);
        script.introVila = 1;
    }
}
