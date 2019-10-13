using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInfo : MonoBehaviour
{
    public Text Name;
    public Text PlayerScore;
    public Text GamesPlayed;
    public Text RotatorSpeed;
    public Text PinSpeed;

    public void Start()
    {
        
        Name.text = PlayerName.playerName.ToString();
        PlayerScore.text = "Score: " + Score.PinCount.ToString();
        GamesPlayed.text = "Games Played: " + GameManager.GamesPlayed.ToString();
        RotatorSpeed.text = "Rotator Speed: " + SliderValuesScript.RotatorSpeed.ToString("f2");
        PinSpeed.text = "Pin Speed: " + SliderValuesScript.PinSpeed.ToString("f2");
    }

    public void Update()
    {
        PlayerScore.text = "Score: " + Score.PinCount.ToString();
    }
}
