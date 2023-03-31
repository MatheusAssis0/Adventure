using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioPonteCavaleiro : MonoBehaviour
{
    private GlobalVars script;
    private PlayerMovement script_;
    [SerializeField] private GameObject tutorial;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
        script_ = FindObjectOfType<PlayerMovement>();
    }

    private void Update()
    {
        if(tutorial.activeSelf == true)
        {
            script_.anim.SetBool("Andando", false);
        }
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
