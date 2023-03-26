using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicaoManager : MonoBehaviour
{
    private Transicao script;
    private GlobalVars script_;

    private void Start()
    {
        script = FindObjectOfType<Transicao>();
        script_ = FindObjectOfType<GlobalVars>();
    }
    public void Play()
    {
        script_.T = 1;
        script.Transition("Casa");
    }

    public void Vila()
    {
        script.Transition("Vila");
    }

    public void VilaCopas()
    {
        script.Transition("Vila copas");
    }

    public void FlorestaDeCopas()
    {
        script.Transition("Floresta de Copas");
    }

    public void PonteDoCavaleiro()
    {
        script.Transition("Ponte cavaleiro");
    }

    public void CasaDaBruxa()
    {
        script.Transition("Bruxa");
    }

    public void Puzzle()
    {
        script.Transition("Puzzle");
    }
}
