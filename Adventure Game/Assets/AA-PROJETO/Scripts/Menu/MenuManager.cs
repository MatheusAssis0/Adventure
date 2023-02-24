using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private Transicao script;

    private void Start()
    {
        script = FindObjectOfType<Transicao>();
    }
    public void Play()
    {
        script.Transition("Jogo");
    }
}
