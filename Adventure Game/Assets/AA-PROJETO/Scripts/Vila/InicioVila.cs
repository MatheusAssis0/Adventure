using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioVila : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private Camera main;
    private PlayerMovement script;
    private GlobalVars _script;

    private void Start()
    {
        _script = FindObjectOfType<GlobalVars>();
        script = FindObjectOfType<PlayerMovement>();

        if(_script.C == 1)
        {
            Vector3 localPos = script.player.transform.localPosition;
            localPos.x = 51.62f;
            script.player.transform.position = localPos;
            Vector3 localPosCam = main.transform.localPosition;
            localPosCam.x = 51.62f;
            main.transform.position = localPosCam;
            Vector3 localScale = script.player.transform.localScale;
            localScale.x *= -1f;
            script.player.transform.localScale = localScale;
            script.isFacingRight = false;
        }
        else if( _script.C == 2)
        {
            Vector3 localPos = script.player.transform.localPosition;
            localPos.x = 69.06f;
            script.player.transform.position = localPos;
            Vector3 localPosCam = main.transform.localPosition;
            localPosCam.x = 69.06f;
            main.transform.position = localPosCam;
            Vector3 localScale = script.player.transform.localScale;
            localScale.x *= -1f;
            script.player.transform.localScale = localScale;
            script.isFacingRight = false;
        }
    }

    private void Update()
    {
        if (canvas.activeSelf == true)
        {
             script.enabled = false;
        }
        else if(canvas.activeSelf == false)
        {
            script.enabled = true;
        }
    }
}
