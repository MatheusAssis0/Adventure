using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudaCamera2 : MonoBehaviour
{
    [SerializeField] private Camera cam1, cam2;
    [SerializeField] private Canvas pause;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
                cam1.depth = 1;
                cam2.depth = 0;
            pause.worldCamera = cam1;
        }
    }
}
