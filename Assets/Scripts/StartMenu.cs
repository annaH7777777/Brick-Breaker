using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public Text highScoreText;
    private void Start()
    {
        if (PlayerPrefs.GetString("HIGHSCORENAME") != ""){
            highScoreText.text = "High Score Set By " + PlayerPrefs.GetString("HIGHSCORENAME") + " " + PlayerPrefs.GetInt("HIGHSCORE");
        }
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit buttin pushed");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }
}
