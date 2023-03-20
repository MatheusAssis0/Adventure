using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fada : MonoBehaviour
{
    private GlobalVars script;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
    }
    public void darItem1()
    {
        script.itemX = 0;
    }
}
