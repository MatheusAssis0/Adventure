using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioVila : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    private PlayerMovement script;

    private void Start()
    {
        script = FindObjectOfType<PlayerMovement>();
    }

    private void Update()
    {
        if (canvas.activeSelf == true)
        {
             script.enabled = false;
        }
        else if(canvas.activeSelf == false)
        {
            script.enabled = true;
        }
    }
}
