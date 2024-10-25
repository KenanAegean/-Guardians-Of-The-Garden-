using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] int timeToWait = 4;
    int currentSceneIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }
    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen");
    }

    public void LoadOptionsMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Options Screen");
    }

    public void LoadNextScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }


    public void LoadYouLose()
    {
        
        SceneManager.LoadScene("Lose Screen");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadLevels()
    {
        SceneManager.LoadScene("Level Selector Screen");
    }

    public void LoadLevel1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level 1");
    }

    public void LoadLevel2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level 2");
    }

    public void LoadLevel3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level 3");
    }

    public void LoadLevel4()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level 4");
    }

    public void LoadLevel5()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level 5");
    }
}
