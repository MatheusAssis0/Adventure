using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCasa : MonoBehaviour
{
    [SerializeField] private GameObject tutorial1, tutorial2, Tutorial;
    private GlobalVars script;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
    }

    private void Update()
    {
        if(script.T == 1)
        {
            tutorial1.SetActive(true);
            tutorial2.SetActive(false);
            Tutorial.SetActive(true);
        }

        if(tutorial1.activeSelf == true && Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.Space))
        {
            script.T = 2;
            Invoke("desligarTutorial1", 2.5f);
            Invoke("ligarTutorial2", 2.5f);
        }

        if(tutorial2.activeSelf == true)
        {
            Invoke("desligarTutorial2", 4f);
        }
    }
    private void desligarTutorial1()
    {
        tutorial1.SetActive(false);
    }
    private void desligarTutorial2()
    {
        Tutorial.SetActive(false);
    }

    private void ligarTutorial2()
    {
        tutorial2.SetActive(true);
    }
}
