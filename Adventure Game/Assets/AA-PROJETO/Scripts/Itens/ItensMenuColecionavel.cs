using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItensMenuColecionavel : MonoBehaviour
{
    [SerializeField] private Image[] item;
    [SerializeField] private GameObject itemInfo, itemDica;
    public enum Opcoes { item1, item2, item3, item4, item5 };
    public Opcoes opcoes;
    private GlobalVars script;

    private void Start()
    {
        script = FindObjectOfType<GlobalVars>();
    }

    private void Update()
    {
        switch (opcoes)
        {
            case (Opcoes.item1):
                if (script.colecionaveis == 0)
                {
                    itemInfo.SetActive(true);
                    itemDica.SetActive(false);
                    var tempColor = item[0].color;
                    tempColor.a = 1f;
                    item[0].color = tempColor;
                }
                break;

            case (Opcoes.item2):
                if (script.colecionaveis == 1)
                {
                    itemInfo.SetActive(true);
                    itemDica.SetActive(false);
                    var tempColor = item[1].color;
                    tempColor.a = 1f;
                    item[1].color = tempColor;
                }
                break;

            case (Opcoes.item3):
                if (script.colecionaveis == 2)
                {
                    itemInfo.SetActive(true);
                    itemDica.SetActive(false);
                    var tempColor = item[2].color;
                    tempColor.a = 1f;
                    item[2].color = tempColor;
                }
                break;

            case (Opcoes.item4):
                if (script.colecionaveis == 3)
                {
                    itemInfo.SetActive(true);
                    itemDica.SetActive(false);
                    var tempColor = item[3].color;
                    tempColor.a = 1f;
                    item[3].color = tempColor;
                }
                break;

            case (Opcoes.item5):
                if (script.colecionaveis == 4)
                {
                    itemInfo.SetActive(true);
                    itemDica.SetActive(false);
                    var tempColor = item[4].color;
                    tempColor.a = 1f;
                    item[4].color = tempColor;
                }
                break;
        }

        if (script.colecionaveis == -1)
        {
            foreach (Image img in item)
            {
                var tempColor = img.color;
                tempColor.a = 0.2f;
                img.color = tempColor;
            }
        }
    }
}
