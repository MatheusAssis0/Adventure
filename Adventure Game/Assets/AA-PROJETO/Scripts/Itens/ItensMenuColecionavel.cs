using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItensMenuColecionavel : MonoBehaviour
{
    [SerializeField] private GameObject itemInfo, itemDica, item1, item2;
    private Colecionaveis script;
    public enum Opcoes {item1, item2 };
    public Opcoes opcoes;


    private void Start()
    {
        script = FindObjectOfType<Colecionaveis>();
    }
    private void Update()
    {
        switch(opcoes)
        {
            case (Opcoes.item1):
                if(script.itemUm.Equals(true))
                {
                    itemInfo.SetActive(true);
                    itemDica.SetActive(false);
                }
                else
                {
                    itemInfo.SetActive(false);
                    itemDica.SetActive(true);
                }
                break;

            case (Opcoes.item2):
                if (script.itemDois.Equals(true))
                {
                    itemInfo.SetActive(true);
                    itemDica.SetActive(false);
                }
                else
                {
                    itemInfo.SetActive(false);
                    itemDica.SetActive(true);
                }
                break;
        }
    }
}
