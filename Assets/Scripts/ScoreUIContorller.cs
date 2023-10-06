using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUIContorller : MonoBehaviour
{
    public TMP_Text scoreText;

    public ScoreManager scoreManager;
    void Update()
    {
        scoreText.text = scoreManager.score.ToString();
    }
}
