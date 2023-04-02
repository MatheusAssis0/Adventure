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
        script.itemFlor = true;
    }
    public void DarItemBruxa()
    {
        script.itemBruxa = true;
    }
    public void DarItemTroll()
    {
        script.itemTroll = true;
    }
    public void DarColecionavelFlor()
    {
        script.colecionavelFlor = true;
    }
    public void DarColecionavelCoracao()
    {
        script.colecionavelCoracao = true;
    }

    public void DarColecionavelPena()
    {
        script.colecionavelPena = true;
    }
    public void DarColecionavelVeludo()
    {
        script.colecionavelVeludo = true;
    }
    public void ZerarInventarioGuarda()
    {
        script.itemBruxa = false;
        script.itemFlor = false;
        script.itemTroll = false;
    }

    public void ZerarInventario()
    {
        script.itemBruxa = false;
        script.itemFlor = false;
        script.itemTroll = false;
        script.colecionavelCoracao = false;
        script.colecionavelFlor = false;
        script.colecionavelPena = false;
        script.colecionavelVeludo = false;
    }
}
