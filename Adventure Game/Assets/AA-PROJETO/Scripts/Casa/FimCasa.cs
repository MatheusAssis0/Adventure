using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FimCasa : MonoBehaviour
{
    [SerializeField] private GameObject texto1, texto2, texto3, texto4, fimImagem, fundoTexto;
    private Transicao script;

    private void Start()
    {
        script = FindObjectOfType<Transicao>();
    }

    private void Texto1()
    {
        fundoTexto.SetActive(true);
        texto1.SetActive(true);
        Invoke("Texto2", 5f);
        Invoke("Texto3", 10f);
        Invoke("Texto4", 15f);
        Invoke("fim", 20f);
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

    private void fim()
    {
        texto4.SetActive(false);
        fundoTexto.SetActive(false);
        script.Transition("Floresta");
    }

    public void inicio()
    {
        fimImagem.SetActive(true);
        Invoke("Texto1", 1f);
        Invoke("Texto2", 6f);
        Invoke("Texto3", 11f);
        Invoke("Texto4", 16f);
        Invoke("fim", 21f);
    }
}
