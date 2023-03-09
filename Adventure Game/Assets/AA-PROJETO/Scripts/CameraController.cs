using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform posPlayer;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float smooth;
    private Vector3 newPos;

    private void Update()
    {
        newPos = transform.position;
        newPos.x = Mathf.Clamp(posPlayer.position.x, minX, maxX);
        newPos.y = posPlayer.position.y;
        transform.position = Vector3.Lerp(transform.position, newPos, smooth * Time.deltaTime);
    }
}
