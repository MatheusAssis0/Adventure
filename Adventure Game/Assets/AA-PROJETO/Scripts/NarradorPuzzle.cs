using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarradorPuzzle : MonoBehaviour
{
    [SerializeField] private GameObject texto1, texto2, texto3, canvas;
    private GameObject musica;
    private GlobalVars script;
    private Transicao script_;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
        script_ = FindObjectOfType<Transicao>();
        musica = GameObject.FindGameObjectWithTag("Musica1");
        Invoke("Texto2", 5f);
        Invoke("Texto3", 10f);
        Invoke("Fim", 15f);
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

    private void Fim()
    {
        texto3.SetActive(false);
        canvas.SetActive(false);
        Object.Destroy(musica);
        script_.Transition("Quarto Rainha");
    }
}

