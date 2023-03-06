using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ND : MonoBehaviour
{
    [HideInInspector]
    public string objectID;
    private Scene cena;

    private void Awake()
    {
        objectID = name + transform.position.ToString() + transform.eulerAngles.ToString();
    }

    private void Start()
    {
        for(int i = 0; i < Object.FindObjectsOfType<ND>().Length; i++)
        {
            if(Object.FindObjectsOfType<ND>()[i] != this)
            {
                if(Object.FindObjectsOfType<ND>()[i].objectID == objectID)
                {
                    Destroy(gameObject);
                }
            }
        }

        DontDestroyOnLoad(gameObject);
    }
}
