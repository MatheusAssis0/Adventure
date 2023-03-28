using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasaBruxa : MonoBehaviour
{
    private GlobalVars script;
    private PlayerMovement script_;
    [SerializeField] private GameObject Tutorial;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
        script_ = FindObjectOfType<PlayerMovement>();
    }

    private void Update()
    {
        if(Tutorial.activeSelf == true)
        {
            script_.enabled = false;
        }
        else
        {
            script_.enabled = true;
        }
    }

    public void EnigmaGuarda()
    {
        script.enigmaGuarda = 1;
    }

    public void EnigmaBruxa()
    {
        script.enigmaBruxa = 1;
    }

    public void ZerouBruxa()
    {
        script.enigmaBruxa = 2;
    }
}
