using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public static int score = 0;

    void Start()
    {
        score = 0;    
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }

    public static void addPoint()
    {
        score++;
    }

    public static int getScore()
    {
        return score;
    }
}
