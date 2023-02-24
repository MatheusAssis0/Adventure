using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject options;
    [SerializeField] private GameObject _sair;
    public bool isPaused;
    private Transicao script;

    private void Start()
    {
        pauseMenu.SetActive(false);
        script = FindObjectOfType<Transicao>();
    }
    private void Update()
    {
        #region btnEsc
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(_sair.activeSelf == true)
            {
                return;
            }
            else
            {
                if (isPaused == true)
                {
                    pauseMenu.SetActive(false);
                    options.SetActive(false);
                    Time.timeScale = 1f;
                    isPaused = false;
                }
                else
                {
                    pauseMenu.SetActive(true);
                    Time.timeScale = 0f;
                    isPaused = true;
                }
            }
        }
        #endregion btnEsc
        #region btnP
        if (pauseMenu.activeSelf == true || options.activeSelf == true)
        {
            return;
        }
        else
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
        #endregion btnP
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        script.Transition("Menu");
    }

    public void QuitGame()
    {
        _sair.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        isPaused = false;
        Time.timeScale = 1f;
    }

    public void Pausar()
    {
        if (isPaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    public void Opcoes()
    {
        options.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void OpcoesRetornar()
    {
        options.SetActive(false);
        pauseMenu.SetActive(true);
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
