using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarradorVila : MonoBehaviour
{
    [SerializeField] private GameObject texto1, texto2, texto3, texto4, canvas;
    private GlobalVars script;
    public enum Opcoes {Vila, PonteCavaleiro, Bruxa}
    public Opcoes opcoes;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
     
        switch (opcoes)
        {
            case Opcoes.Vila:
                if (script.introVila == 1)
                {
                    canvas.SetActive(false);
                }
                Invoke("Texto2", 5f);
                Invoke("Texto3", 10f);
                Invoke("Texto4", 15f);
                Invoke("FimVila", 20f);
                break;
            case Opcoes.PonteCavaleiro:
                if (script.narradorTroll == true)
                {
                    canvas.SetActive(false);
                }
                Invoke("Texto2", 5f);
                Invoke("Texto3", 10f);
                Invoke("Texto4", 15f);
                Invoke("FimTroll", 20f);
                break;
            case Opcoes.Bruxa:
                if (script.narradorBruxa == true)
                {
                    canvas.SetActive(false);
                }
                Invoke("Texto2", 5f);
                Invoke("Texto3", 10f);
                Invoke("Texto4", 15f);
                Invoke("FimBruxa", 20f);
                break;
                  
        }
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

    private void FimVila()
    {
        texto4.SetActive(false);
        canvas.SetActive(false);
        script.introVila = 1;
    }

    private void FimTroll()
    {
        texto4.SetActive(false);
        canvas.SetActive(false);
        script.narradorTroll = true;
    }

    private void FimBruxa()
    {
        texto4.SetActive(false);
        canvas.SetActive(false);
        script.narradorBruxa = true;
    }
}
