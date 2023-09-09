using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score = 0;

    void Start()
    {

    }

    void Update()
    {
        scoreText.text = score.ToString();
    }
}
