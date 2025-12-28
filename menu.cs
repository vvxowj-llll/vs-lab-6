using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string firstLevelName;

    public void StartGame()
    {
        SceneManager.LoadScene(firstLevelName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}