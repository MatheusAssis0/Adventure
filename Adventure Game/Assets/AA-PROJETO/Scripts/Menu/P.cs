using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P : MonoBehaviour
{
    [SerializeField] private GameObject _sair;
    private void Update()
    {
        if (_sair.activeSelf == false)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                _sair.SetActive(true);
                Time.timeScale = 0f;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                _sair.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }

    public void FecharJogo()
    {
        Application.Quit();
    }
    public void Continuar()
    {
        _sair.SetActive(false);
        Time.timeScale = 1f;
    }
}
