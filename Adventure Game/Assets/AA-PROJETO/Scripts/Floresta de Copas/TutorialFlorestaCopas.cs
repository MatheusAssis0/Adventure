using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialFlorestaCopas : MonoBehaviour
{
    [SerializeField] private GameObject tutorial1, tutorial2, tutorial3, Tutorial;


    private void Update()
    {
        if(tutorial1.activeSelf == true && Input.GetKeyDown(KeyCode.I))
        {
            desligarTutorial1();
            ligarTutorial2();
        }

        if(tutorial2.activeSelf == true && Input.GetKeyDown(KeyCode.C))
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
