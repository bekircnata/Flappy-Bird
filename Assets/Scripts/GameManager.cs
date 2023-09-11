using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject startScreen;
    public GameObject gameOverScreen;

    public int score = 0;
    public bool isGameOver = false;

    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        scoreText.text = score.ToString();
        GameOver();
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        startScreen.SetActive(false);
    }

    void GameOver()
    {
        if(isGameOver)
        {
            Time.timeScale = 0;
            gameOverScreen.SetActive(true);
        }
    }

    public void RestartGame()
    {
        isGameOver = false;
        gameOverScreen.SetActive(false);
        SceneManager.LoadScene(0);
    }

 }
