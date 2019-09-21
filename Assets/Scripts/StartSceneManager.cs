using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSceneManager : MonoBehaviour
{
    [SerializeField]
    private Text fiveSecScore;
    [SerializeField]
    private Text tenSecScore;
    [SerializeField]
    private Text twentySecScore;
    [SerializeField]
    private Text thirtySecScore;
    [SerializeField]
    private Text fortySecScore;
    [SerializeField]
    private Text fiftySecScore;
    [SerializeField]
    private Text sixtySecScore;

    [SerializeField]
    private Text fiveTimesPlayed;
    [SerializeField]
    private Text tenTimesPlayed;
    [SerializeField]
    private Text twentyTimesPlayed;
    [SerializeField]
    private Text thirtyTimesPlayed;
    [SerializeField]
    private Text fortyTimesPlayed;
    [SerializeField]
    private Text fiftyTimesPlayed;
    [SerializeField]
    private Text sixtyTimesPlayed;

    private void Start()
    {
        fiveSecScore.text = "" + PlayerPrefs.GetInt("5HighScore");
        tenSecScore.text = "" + PlayerPrefs.GetInt("10HighScore");
        twentySecScore.text = "" + PlayerPrefs.GetInt("20HighScore");
        thirtySecScore.text = "" + PlayerPrefs.GetInt("30HighScore");
        fortySecScore.text = "" + PlayerPrefs.GetInt("40HighScore");
        fiftySecScore.text = "" + PlayerPrefs.GetInt("50HighScore");
        sixtySecScore.text = "" + PlayerPrefs.GetInt("60HighScore");

        fiveTimesPlayed.text = "" + PlayerPrefs.GetInt("Games5Played");
        tenTimesPlayed.text = "" + PlayerPrefs.GetInt("Games10Played");
        twentyTimesPlayed.text = "" + PlayerPrefs.GetInt("Games20Played");
        thirtyTimesPlayed.text = "" + PlayerPrefs.GetInt("Games30Played");
        fortyTimesPlayed.text = "" + PlayerPrefs.GetInt("Games40Played");
        fiftyTimesPlayed.text = "" + PlayerPrefs.GetInt("Games50Played");
        sixtyTimesPlayed.text = "" + PlayerPrefs.GetInt("Games60Played");
    }

    public void LoadGameplayScene()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
