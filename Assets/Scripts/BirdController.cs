using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    private Rigidbody2D birdRb;
    [SerializeField] private GameManager gameManager;

    [SerializeField] private float jumpForce = 2f;
    [SerializeField] private float maxYPosition = 1f;

    void Start()
    {
        birdRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        BirdControl();
    }

    void BirdControl()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (transform.position.y < maxYPosition)
            {
                birdRb.velocity = Vector2.up * jumpForce;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Pipe")
        {
            gameManager.isGameOver = true;
        }
    }

}
