using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVars : MonoBehaviour
{
    public float A;
    public float T;
    public float introVila;
    public float objtvCasa;
    public float itens;
    public bool colecionavel;
    public bool isPaused;

    private void Awake()
    {
        itens = -1;
    }
}
