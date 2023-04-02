using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narrador : MonoBehaviour
{
    [SerializeField] private GameObject texto1, texto2, texto3, texto4, canvas, fim;
    private GlobalVars script;
    private Transicao script_;
    private PlayerMovement script0;
    private GameObject musica;
    public enum Opcoes {Vila, PonteCavaleiro, Bruxa, Rainha}
    public Opcoes opcoes;

    private void Start()
    {
        script_ = FindObjectOfType<Transicao>();
        script = FindObjectOfType<GlobalVars>();
        script0 = FindObjectOfType<PlayerMovement>();
        musica = GameObject.FindGameObjectWithTag("Musica1");
     
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
                Invoke("Texto4", 18f);
                Invoke("FimBruxa", 23f);
                break;
            case Opcoes.Rainha:
                if(canvas.activeSelf == true)
                {
                    script0.enabled = false;
                }
                Invoke("Texto2", 5f);
                Invoke("Texto3", 10f);
                Invoke("Texto4", 18f);
                Invoke("FimRainha", 23f);
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

    private void FimRainha()
    {
        texto4.SetActive(false);
        canvas.SetActive(false);
        fim.SetActive(true);
        Invoke("TpMenu", 5f);
        Object.Destroy(musica);
    }
    private void TpMenu()
    {
        script.A = 0;
        script.T = 0;
        script.C = 0;
        script.CC = 0;
        script.introVila = 0;
        script.objtvCasa = 0;
        script.enigmaBruxa = 0;
        script.enigmaTroll = 0;
        script.enigmaGuarda = 0;
        script.guardaBruxa = false;
        script.enigmaGuardaFloresta = false;
        script.narradorBruxa = false;
        script.narradorTroll = false;
        script.tutorialFlorestaCopas = false;
        script.itemBruxa = false;
        script.itemFlor = false;
        script.itemTroll = false;
        script.colecionavelCoracao = false;
        script.colecionavelFlor = false;
        script.colecionavelPena = false;
        script.colecionavelVeludo = false;
        script_.Transition("Menu");
    }
}
