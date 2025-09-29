using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // This line enables use of uGUI classes like Text.        // a

public class ScoreCounter : MonoBehaviour
{
    [Header("Dynamic")]                                                          // b
    public int score = 0;
    public int level = 0;
    public int pointsPerLevel = 500;

    private Text uiText;                                                        // c

    void Start()
    {
        uiText = GetComponent<Text>();                                           // d
    }

    void Update()
    {
        level = score / pointsPerLevel;
        uiText.text = "Level: " + level + " Score: " + score.ToString("#,0");
    }
}
