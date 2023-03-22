using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioFlorestaCopas : MonoBehaviour
{
    private PlayerMovement script;
    [SerializeField] private GameObject tutorial;

    private void Start()
    {
        script = FindObjectOfType<PlayerMovement>();
    }

    private void Update()
    {
        if(tutorial.activeSelf == true)
        {
            script.enabled= false;
        }
        else
        {
            script.enabled= true;
        }
    }
}
