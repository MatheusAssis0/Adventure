using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasaCoronel : MonoBehaviour
{
    [SerializeField] private BoxCollider2D col;
    private GlobalVars script;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
    }

    private void Update()
    {
        if(script.A == 1)
        {
            col.enabled = true;
        }
    }
    public void casaLiberada()
    {
        script.A = 1;
    }
}
