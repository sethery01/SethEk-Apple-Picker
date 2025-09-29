using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;     // We need this line for uGUI to work.

public class GameOverUI : MonoBehaviour
{
    public Text message;
    void Start()
    {
        int SCORE = PlayerPrefs.GetInt("HighScore");
        message.text = "High Score: " + SCORE;
    }
}
