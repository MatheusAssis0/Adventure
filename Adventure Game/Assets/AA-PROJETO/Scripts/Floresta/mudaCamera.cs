using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudaCamera : MonoBehaviour
{
    [SerializeField] private Camera cam1, cam2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
                cam1.depth = 0;
                cam2.depth = 1;
        }
    }
}
