using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioFloresta : MonoBehaviour
{
    [SerializeField] private Camera main;
    [SerializeField] private GameObject canvas;
    private GameObject musica;
    private PlayerMovement script;

    private void Start()
    {
        script = FindObjectOfType<PlayerMovement>();
        musica = GameObject.FindGameObjectWithTag("Musica1");
    }

    public void DestruirMusica()
    {
        Object.Destroy(musica);
    }

    private void Update()
    {
        if (canvas.activeSelf == true)
        {
            script.enabled = false;
            script.anim.SetBool("Andando", false);
        }
        else if (canvas.activeSelf == false)
        {
            script.enabled = true;
        }
    }
}
