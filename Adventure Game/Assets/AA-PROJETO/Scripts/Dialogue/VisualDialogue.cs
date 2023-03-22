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

    public void ColocarItalicoBold()
    {
        texto.fontStyle = FontStyles.Italic | FontStyles.Bold;
    }

    public void TirarItalico()
    {
        texto.fontStyle = FontStyles.Normal;
    }

}
