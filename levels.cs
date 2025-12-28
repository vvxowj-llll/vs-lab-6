using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject[] levels;
    private int currentLevel = 0;

    void Start()
    {
        LoadLevel(currentLevel);
    }

    public void LoadLevel(int levelIndex)
    {
        if (levelIndex >= 0 && levelIndex < levels.Length)
        {
            Instantiate(levels[levelIndex]);
        }
    }

    public void LoadNextLevel()
    {
        currentLevel++;
        if (currentLevel < levels.Length)
        {
            LoadLevel(currentLevel);
        }
        else
        {
            Debug.Log("Все уровни пройдены!");
        }
    }
}