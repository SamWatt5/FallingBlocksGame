using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public void AddScore()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }
}
