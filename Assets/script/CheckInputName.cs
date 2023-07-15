using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheckInputName : MonoBehaviour
{
    public Text inputName;

    public void checkName()
    {
        if (inputName.text.Trim() != "")
        {
            RatingMenu.addScore(inputName.text, ScoreManager.score.ToString());
            SceneManager.LoadScene(2);
        }
    }
}
