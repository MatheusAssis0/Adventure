using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItensInventario : MonoBehaviour
{
    [SerializeField] private GameObject Item1;
    [SerializeField] private GameObject Item2;
    public enum ItensColecionaveis { item1, item2 };
    public ItensColecionaveis Itenscolecionaveis;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            switch (Itenscolecionaveis)
            {
                case (ItensColecionaveis.item1):
                    Destroy(this.gameObject);
                    Item1.SetActive(true);
                    break;

                case (ItensColecionaveis.item2):
                    Destroy(this.gameObject);
                    Item2.SetActive(true);
                    break;
            }
        }
    }
}
