using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float pipeMoveSpeed = 0.6f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * pipeMoveSpeed * Time.deltaTime;
    }
}