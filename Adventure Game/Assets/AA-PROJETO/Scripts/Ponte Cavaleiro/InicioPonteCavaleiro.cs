using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioPonteCavaleiro : MonoBehaviour
{
    private GlobalVars script;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
    }

    public void EnigmaTroll()
    {
        script.enigmaTroll = 1;
    }
    public void ZerouTroll()
    {
        script.enigmaTroll = 2;
    }
}
