using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioVilaCopas : MonoBehaviour
{
    [SerializeField] private Camera main;
    private PlayerMovement script;
    private GlobalVars _script;

    private void Start()
    {
        _script = FindObjectOfType<GlobalVars>();
        script = FindObjectOfType<PlayerMovement>();

        if (_script.CC == 1)
        {
            Vector3 localPos = script.player.transform.localPosition;
            localPos.x = 54.96f;
            script.player.transform.position = localPos;
            Vector3 localPosCam = main.transform.localPosition;
            localPosCam.x = 54.96f;
            main.transform.position = localPosCam;
            Vector3 localScale = script.player.transform.localScale;
            localScale.x *= -1f;
            script.player.transform.localScale = localScale;
            script.isFacingRight = false;
        }
    }
}
