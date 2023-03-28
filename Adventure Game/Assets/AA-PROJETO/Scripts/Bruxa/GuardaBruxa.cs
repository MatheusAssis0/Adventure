using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardaBruxa : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject guarda;
    private GlobalVars script;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
    }

    private void Update()
    {
        if (script.enigmaGuarda == 1)
        {
            anim.SetBool("enigma", true);
            Invoke("DestruirGuarda", 2f);
        }

        if(script.guardaBruxa == true)
        {
            Destroy(guarda);
        }
    }

    private void DestruirGuarda()
    {
        Destroy(guarda);
        script.guardaBruxa = true;
    }
}
