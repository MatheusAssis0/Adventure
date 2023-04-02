using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItensMenuColecionavel : MonoBehaviour
{
    [SerializeField] private Image[] item;
    [SerializeField] private GameObject itemInfo, itemDica;
    public enum Opcoes { item1, item2, item3, item4, };
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
                if (script.colecionavelFlor == true)
                {
                    itemInfo.SetActive(true);
                    itemDica.SetActive(false);
                    var tempColor = item[0].color;
                    tempColor.a = 1f;
                    item[0].color = tempColor;
                }
                break;

            case (Opcoes.item2):
                if (script.colecionavelCoracao == true)
                {
                    itemInfo.SetActive(true);
                    itemDica.SetActive(false);
                    var tempColor = item[1].color;
                    tempColor.a = 1f;
                    item[1].color = tempColor;
                }
                break;

            case (Opcoes.item3):
                if (script.colecionavelPena == true)
                {
                    itemInfo.SetActive(true);
                    itemDica.SetActive(false);
                    var tempColor = item[2].color;
                    tempColor.a = 1f;
                    item[2].color = tempColor;
                }
                break;

            case (Opcoes.item4):
                if (script.colecionavelVeludo == true)
                {
                    itemInfo.SetActive(true);
                    itemDica.SetActive(false);
                    var tempColor = item[3].color;
                    tempColor.a = 1f;
                    item[3].color = tempColor;
                }
                break;
        }

        if (script.colecionavelVeludo == false && script.colecionavelCoracao == false && script.colecionavelPena == false && script.colecionavelFlor == false)
        {
            foreach (Image img in item)
            {
                itemInfo.SetActive(false);
                itemDica.SetActive(true);
                var tempColor = img.color;
                tempColor.a = 0.2f;
                img.color = tempColor;
            }
        }
    }
}
