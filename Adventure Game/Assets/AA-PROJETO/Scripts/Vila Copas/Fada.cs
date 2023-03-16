using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fada : MonoBehaviour
{
    private GameObject item1;

    private void Start()
    {
        if (item1 == null)
        {
            item1 = GameObject.FindGameObjectWithTag("Item1");
        }
    }
    public void darItem1()
    {
        item1.SetActive(true);
    }
}
