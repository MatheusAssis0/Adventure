using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VisualDialogue : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI texto;
    [SerializeField] private Color normalColor, enigmaColor;

    public void ConfiguraCorNormal()
    {
        texto.color = normalColor;
    }

    public void ConfiguraCorEnigma()
    {
        texto.color = enigmaColor;
    }

    public void ColocarItalico()
    {
        texto.fontStyle = FontStyles.Italic;
    }

    public void TirarItalico()
    {
        texto.fontStyle = FontStyles.Normal;
    }

}
