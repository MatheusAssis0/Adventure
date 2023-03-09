using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicaoManager : MonoBehaviour
{
    private Transicao script;

    private void Start()
    {
        script = FindObjectOfType<Transicao>();
    }
    public void Play()
    {
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
}
