using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NpcsCasa : MonoBehaviour
{
    [SerializeField] private GameObject coronel, npc;
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
            npc.SetActive(false);
        }
        else if(script.A == 2)
        {
            coronel.SetActive(false);
            npc.SetActive(true);
        }
        else
        {
            coronel.SetActive(false);
            npc.SetActive(false);
        }
    }
}
