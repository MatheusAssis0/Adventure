using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setasMenuColecionavel : MonoBehaviour
{
    public GameObject[] colecionaveis;
    public int _index;

    public void Esquerda()
    {
        if(_index == 0)
        {
            _index = 4;
            colecionaveis[4].SetActive(true);
            colecionaveis[0].SetActive(false);
        }
        else
        {
            _index = Mathf.Clamp(_index - 1, 0, 4);
            colecionaveis[_index].SetActive(true);
            colecionaveis[_index + 1].SetActive(false);
        }
    }

    public void Direita()
    {
        if (_index == 4)
        {
            _index = 0;
            colecionaveis[0].SetActive(true);
            colecionaveis[4].SetActive(false);
        }
        else
        {
            _index = Mathf.Clamp(_index + 1, 0, 4);
            colecionaveis[_index].SetActive(true);
            colecionaveis[_index - 1].SetActive(false);
        }
    }
}
