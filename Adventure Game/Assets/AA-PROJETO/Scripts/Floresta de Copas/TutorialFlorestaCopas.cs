using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialFlorestaCopas : MonoBehaviour
{
    [SerializeField] private GameObject tutorial1, tutorial2, tutorial3, Tutorial;
    private int cKeyCount, iKeyCount;


    private void Update()
    {
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
