using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjetivoAtual : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI texto;         
    private float velocidade = 30f; 
    private string textoCompleto;
    private char[] chars;
    private float cronometro = 0f;
    private int indexAtual = 0;

    void Start()
    {
        Time.timeScale = 1f;
        textoCompleto = texto.text;
        texto.text = "";
        chars = textoCompleto.ToCharArray();
    }

    private void Update()
    {
        if (indexAtual < chars.Length)
        {
            cronometro += Time.deltaTime;
            if (cronometro > 1 / velocidade)
            {
                cronometro = 0;
                texto.text += chars[indexAtual].ToString();
                indexAtual++;
            }
        }
    }
}
