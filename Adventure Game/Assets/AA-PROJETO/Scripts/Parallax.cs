using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private GameObject cameraPlayer;
    [SerializeField] private float speedParallax;
    private float length, startPos;

    private void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void FixedUpdate()
    {
        float temp = (cameraPlayer.transform.position.x * (1 - speedParallax));
        float dist = (cameraPlayer.transform.position.x * speedParallax);

        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);

        if(temp > startPos + length / 2)
        {
            startPos += length;
        }
        else if (temp < startPos - length / 2)
        {
            startPos -= length;
        }
    }
}
