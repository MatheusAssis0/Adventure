using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarradorFloresta : MonoBehaviour
{
    [SerializeField] private GameObject texto1, texto2, texto3, canvas;
    [SerializeField] private Animator anim;

    private void Start()
    {
        anim.SetBool("Andando", false);
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
    }
}
