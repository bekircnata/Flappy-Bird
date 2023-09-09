using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    public float parallaxSpeed = 1.0f; // Hareket hýzý
    private Vector2 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        GroundMoveAnimation();
    }

    void GroundMoveAnimation()
    {
        float newPosition = Mathf.Repeat(Time.time * parallaxSpeed, 1.9f);
        transform.position = startPosition + Vector2.left * newPosition;
    }
}
