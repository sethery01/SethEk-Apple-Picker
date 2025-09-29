using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AppleTree appleTree;      
    public ScoreCounter scoreCounter; 
    private int lastLevel = -1;

    void Update()
    {
        if (scoreCounter.level != lastLevel)
        {
            lastLevel = scoreCounter.level;
            appleTree.SetDifficulty(lastLevel);
        }
    }
}
