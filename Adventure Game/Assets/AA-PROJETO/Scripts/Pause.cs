using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject options;
    [SerializeField] private GameObject _sair;
    private Transicao script;
    private GlobalVars script_;

    private void Start()
    {
        pauseMenu.SetActive(false);
        script = FindObjectOfType<Transicao>();
        script_ = FindObjectOfType<GlobalVars>();
        
    }
    private void Update()
    {
        #region btnEsc
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(_sair.activeSelf == true || script_.colecionavel == true)
            {
                return;
            }
            else
            {
                if (script_.isPaused == true)
                {
                    pauseMenu.SetActive(false);
                    options.SetActive(false);
                    Time.timeScale = 1f;
                    script_.isPaused = false;
                }
                else
                {
                    pauseMenu.SetActive(true);
                    Time.timeScale = 0f;
                    script_.isPaused = true;
                }
            }
        }
        #endregion btnEsc
        #region btnP
        if (pauseMenu.activeSelf == true || options.activeSelf == true || script_.colecionavel == true)
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
                    script_.isPaused = true;
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.P))
                {
                    _sair.SetActive(false);
                    Time.timeScale = 1f;
                    script_.isPaused = false;
                }
            }
        }
        #endregion btnP
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        script_.isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        script_.isPaused = false;
    }

    public void GoToMainMenu()
    {
        script_.A = 0;
        Time.timeScale = 1f;
        script_.isPaused = false;
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
        script_.isPaused = false;
        Time.timeScale = 1f;
    }

    public void Pausar()
    {
        if (script_.isPaused)
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
