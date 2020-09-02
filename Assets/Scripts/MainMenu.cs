using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _creditsWindow;

    public void OnPlayButtonClick()
    {
        SceneManager.LoadScene(1);
    }

    public void OnCreditsButtonClick()
    {
        _creditsWindow.SetActive(true);
    }

    public void OnCreditsWiondowClick()
    {
        _creditsWindow.SetActive(false);
    }

    public void OnQuitButtonQlick()
    {
        Application.Quit();
    }
}
