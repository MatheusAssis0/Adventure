using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colecionaveis : MonoBehaviour
{
    [SerializeField] private GameObject Item1;
    [SerializeField] private GameObject Item2;
    public bool itemUm, itemDois;
    public enum ItensColecionaveis { item1, item2};
    public ItensColecionaveis Itenscolecionaveis;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            switch (Itenscolecionaveis)
            {
                case (ItensColecionaveis.item1):
                    Destroy(this.gameObject);
                    itemUm = true;
                    Item1.GetComponent<Image>().color += new Color(0, 0, 0, 255);
                break;

                case (ItensColecionaveis.item2):
                    Destroy(this.gameObject);
                    itemDois = true;
                    Item2.GetComponent<Image>().color += new Color(0, 0, 0, 255);
                break;
            }
        }
    }
}
