using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnPlayButtonClick()
    {
        SceneManager.LoadScene(1);
    }

    public void OnQuitButtonQlick()
    {
        Application.Quit();
    }
}
