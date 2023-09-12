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
    public bool isPlay = false;

    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void StartGame()
    {
        isPlay = true;
        startScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        isGameOver = true;
        isPlay = false;
        gameOverScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        isGameOver = false;
        gameOverScreen.SetActive(false);
        SceneManager.LoadScene(0);
    }

 }
