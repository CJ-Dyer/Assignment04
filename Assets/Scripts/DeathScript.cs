using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScript : MonoBehaviour
{
    public Text DeathScore;
    public Text HighScore;

    void Start()
    {

        if (Score.PinCount >= PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", Score.PinCount);
            PlayerPrefs.SetString("HighScorePlayerName", PlayerName.playerName);
        }

        DeathScore.text = "Score: " + Score.PinCount.ToString();
        HighScore.text = "High Score: " + PlayerPrefs.GetString("HighScorePlayerName", "default") + " - " + PlayerPrefs.GetInt("HighScore", 0);
    }
}
