using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarItem : MonoBehaviour
{
    private GlobalVars script;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
    }
    public void DarItem1()
    {
        script.itens = 0;
    }
    public void DarItem2()
    {
        script.itens = 1;
    }
    public void DarItem3()
    {
        script.itens = 2;
    }
    public void DarItem4()
    {
        script.itens = 3;
    }
    public void DarItem5()
    {
        script.itens = 4;
    }
    public void DarItem6()
    {
        script.itens = 5;
    }
    public void DarItem7()
    {
        script.itens = 6;
    }

    public void DarColecionavelFlor()
    {
        script.colecionaveis = 0;
    }
    public void DarColecionavelCha()
    {
        script.colecionaveis = 4;
    }

    public void DarColecionavelPena()
    {
        script.colecionaveis = 2;
    }
}
