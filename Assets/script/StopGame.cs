using UnityEngine;
using UnityEngine.SceneManagement;

public class StopGame : MonoBehaviour
{
    public void checkScore()
    {
        if (ScoreManager.getScore() > 0 && RatingMenu.checkListScore(ScoreManager.getScore()))
        {
            SceneManager.LoadScene(3);

        } else
        {
            SceneManager.LoadScene(0);
        }
    }
}
