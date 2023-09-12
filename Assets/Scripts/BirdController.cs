using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    private Rigidbody2D birdRb;
    [SerializeField] private GameManager gameManager;

    [SerializeField]  private AudioClip wingSound;
    [SerializeField]  private AudioClip hitSound;
    private AudioSource audioSource;

    [SerializeField] private float jumpForce = 2f;
    [SerializeField] private float maxYPosition = 1f;

    void Start()
    {
        birdRb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        BirdControl();
    }

    void BirdControl()
    {
        if (Input.GetMouseButtonDown(0) && !gameManager.isGameOver && gameManager.isPlay)
        {
            if (transform.position.y < maxYPosition)
            {
                birdRb.velocity = Vector2.up * jumpForce;
                audioSource.clip = wingSound;
                audioSource.Play();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Pipe")
        {
            gameManager.GameOver();
            audioSource.clip = hitSound;
            audioSource.Play();
        }
    }

}
