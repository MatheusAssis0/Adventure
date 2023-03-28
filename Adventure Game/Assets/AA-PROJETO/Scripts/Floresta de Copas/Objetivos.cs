using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetivos : MonoBehaviour
{
    [SerializeField] private GameObject objetivo1, objetivo2, objetivo3;
    private GlobalVars script;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
    }

    private void Update()
    {
        if (script.enigmaBruxa == 1 || script.enigmaTroll == 1)
        {
            objetivo1.SetActive(false);
            objetivo2.SetActive(true);
        }
        else if (script.enigmaBruxa == 1 && script.enigmaTroll == 1)
        {
            objetivo2.SetActive(false);
            objetivo3.SetActive(true);
        }
    }

    public void EnigmaGuardaFloresta()
    {
        script.enigmaGuardaFloresta = true;
    }
}
