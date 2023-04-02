using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipPuzzle : MonoBehaviour
{
    private PuzzleManager script;

    private void Start()
    {
        script = FindObjectOfType<PuzzleManager>();
    }

    public void Skipar()
    {
        script.Venceu();
    }
}
