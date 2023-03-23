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
    public bool colecionavel;
    public bool isPaused;

    private void Awake()
    {
        itens = -1;
        colecionaveis= -1;
    }
}
