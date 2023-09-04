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
        GroundMovaAnimation();
    }

    void GroundMovaAnimation()
    {
        float newPosition = Mathf.Repeat(Time.time * parallaxSpeed, 1.9f);
        Debug.Log(newPosition);
        transform.position = startPosition + Vector2.left * newPosition;
    }
}
