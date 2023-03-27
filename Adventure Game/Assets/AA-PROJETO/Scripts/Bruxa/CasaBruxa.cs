using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasaBruxa : MonoBehaviour
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
        if(script.enigmaGuarda == 1)
        {
            anim.SetBool("enigma", true);
            Invoke("DestruirGuarda", 2f);
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

    private void DestruirGuarda()
    {
        Destroy(guarda);
    }
}
