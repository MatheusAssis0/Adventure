using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botaoE : MonoBehaviour
{
    [SerializeField] private Transform player;

    private void Update()
    {
        this.transform.position = new Vector2(player.transform.position.x, player.transform.position.y + 1.5f);
    }
}
