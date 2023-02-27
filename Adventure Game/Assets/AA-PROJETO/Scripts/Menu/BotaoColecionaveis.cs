using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoColecionaveis : MonoBehaviour
{
    [SerializeField] private GameObject colecionaveis;
    [SerializeField] private GameObject inventario;
    [SerializeField] private GameObject pauseMenu, optionsMenu, sairMenu;
    private Pause script;


    private void Start()
    {
        script = FindObjectOfType<Pause>();
    }
    private void Update()
    {
        if(Time.timeScale == 1f)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                if (inventario.activeSelf == true)
                {
                    inventario.SetActive(false);
                }
                else
                {
                    inventario.SetActive(true);
                }
            }
        }

        if (pauseMenu.activeSelf == false && optionsMenu.activeSelf == false && sairMenu.activeSelf == false)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                if (colecionaveis.activeSelf == true)
                {
                    colecionaveis.SetActive(false);
                    Time.timeScale = 1f;
                    script.isPaused = false;
                }
                else
                {
                    colecionaveis.SetActive(true);
                    Time.timeScale = 0f;
                    script.isPaused = true;
                }
            }
        }
    }
    /*public void botao()
    {
        if(colecionaveis.activeSelf == true)
        {
            colecionaveis.SetActive(false);
        }
        else
        {
            colecionaveis.SetActive(true);
        }
    }*/
}
