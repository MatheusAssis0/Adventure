using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax_Menu : MonoBehaviour
{
    [SerializeField] private MeshRenderer background;
    [SerializeField] private float speed;

    private void Update()
    {
        background.material.mainTextureOffset += new Vector2 (speed * Time.deltaTime, 0);
    }
}
