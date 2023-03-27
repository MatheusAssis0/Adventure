using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class GlobalVars : MonoBehaviour
{
    public int A;
    public int T;
    public int C;
    public int CC;
    public int introVila;
    public int objtvCasa;
    public int itens;
    public int colecionaveis;
    public int enigmaTroll, enigmaBruxa, enigmaGuarda;
    public bool colecionavel;
    public bool isPaused;
    public bool narradorTroll, narradorBruxa;

    private void Awake()
    {
        itens = -1;
        colecionaveis= -1;
    }
}
