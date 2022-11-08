using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score = 0;
    public int _score {
        get { return score; }
        set { 
            score = value;
            scoreText.text = score.ToString();
        }
    }
    public Text scoreText;
}
