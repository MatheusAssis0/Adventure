using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItensMenuColecionavel : MonoBehaviour
{
    [SerializeField] private GameObject itemInfo, itemDica, item1, item2, item3, item4, item5;
    public enum Opcoes {item1, item2, item3, item4, item5 };
    public Opcoes opcoes;


    
    private void Update()
    {
       /* switch(opcoes)
        {
            case (Opcoes.item1):
                if(script.colecionaveis == 0)
                {
                    itemInfo.SetActive(true);
                    itemDica.SetActive(false);
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

            case (Opcoes.item3):
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

            case (Opcoes.item4):
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

            case (Opcoes.item5):
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
                break;*/
        }
    }
