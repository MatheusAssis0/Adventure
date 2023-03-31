using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialFlorestaCopas : MonoBehaviour
{
    [SerializeField] private GameObject tutorial1, tutorial2, tutorial3, Tutorial;
    private PlayerMovement script_;
    private int cKeyCount, iKeyCount;
    private GlobalVars script;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
        script_ = FindObjectOfType<PlayerMovement>();
    }

    private void Update()
    {
        if(Tutorial.activeSelf == true)
        {
            script_.anim.SetBool("Andando", false);
        }

        if(script.tutorialFlorestaCopas == true)
        {
            Tutorial.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            cKeyCount++;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            iKeyCount++;
        }

        if (tutorial1.activeSelf == true && iKeyCount == 2)
        {
            desligarTutorial1();
            ligarTutorial2();
        }

        if(tutorial2.activeSelf == true && cKeyCount == 2)
        {
            desligarTutorial2();
            ligarTutorial3();
            Invoke("desligarTutorial3", 10f);
        }
    }

    private void desligarTutorial1()
    {
        tutorial1.SetActive(false);
    }

    private void desligarTutorial2()
    {
        tutorial2.SetActive(false);
    }
    private void desligarTutorial3()
    {
        Tutorial.SetActive(false);
        script.tutorialFlorestaCopas = true;
    }

    private void ligarTutorial3()
    {
        tutorial3.SetActive(true); 
    }

    private void ligarTutorial2()
    {
        tutorial2.SetActive(true);
    }
}
