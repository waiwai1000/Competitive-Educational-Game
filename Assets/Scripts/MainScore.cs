﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScore : MonoBehaviour
{
    public Text englishScore;
    public Text mathScore;

    private DataController dataController;
    private MathDataController mathdataController;

    void Start()
    {
        englishScore.text = PlayerPrefs.GetInt("highestScore1").ToString();
        mathScore.text = PlayerPrefs.GetInt("mathscore").ToString();
    }
}
