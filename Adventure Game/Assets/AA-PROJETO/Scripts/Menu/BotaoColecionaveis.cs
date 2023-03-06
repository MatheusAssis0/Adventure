using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoColecionaveis : MonoBehaviour
{
    [SerializeField] private GameObject colecionaveis;
    [SerializeField] private GameObject inventario;
    private Scene cena;
    private GlobalVars script;


    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
    }
    private void Update()
    {
        cena = SceneManager.GetActiveScene();

        if (Time.timeScale == 1f)
        {
            if (cena.buildIndex != 0)
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
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (cena.buildIndex != 0)
            {
                if (script.isPaused == false)
                {
                    colecionaveis.SetActive(true);
                    script.colecionavel = true;
                    Time.timeScale = 0f;
                    script.isPaused = true;
                }
                else if (script.isPaused == true && colecionaveis.activeSelf == true)
                {
                    colecionaveis.SetActive(false);
                    script.colecionavel = false;
                    Time.timeScale = 1f;
                    script.isPaused = false;
                }
            }
        }
    }
}
