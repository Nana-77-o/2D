﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
    public Text ScoreText;
    int score;
    void Start()
    {
        score = Bird.getscore();
        ScoreText.text = string.Format("Score:{0}", score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
