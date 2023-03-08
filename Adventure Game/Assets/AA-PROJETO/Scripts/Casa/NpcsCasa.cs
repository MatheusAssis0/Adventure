using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NpcsCasa : MonoBehaviour
{
    [SerializeField] private GameObject coronel, npcLouco, npcFlu;
    private GlobalVars script;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
    }

    private void Update()
    {
        if(script.A == 1)
        {
            coronel.SetActive(true);
            npcLouco.SetActive(false);
            npcFlu.SetActive(false);
        }
        else if(script.A == 2)
        {
            coronel.SetActive(false);
            npcLouco.SetActive(true);
            npcFlu.SetActive(false);
        }
        else if(script.A == 3)
        {
            coronel.SetActive(false);
            npcLouco.SetActive(false);
            npcFlu.SetActive(true);
        }
        else
        {
            coronel.SetActive(false);
            npcLouco.SetActive(false);
            npcFlu.SetActive(false);
        }
    }
}
