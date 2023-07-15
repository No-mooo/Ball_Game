using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void Play() 
    {
        SceneManager.LoadScene(1);
    }

    public void ShowRatingMenu()
    {
        SceneManager.LoadScene(2);
    }
}
