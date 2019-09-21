using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndSceneManager : MonoBehaviour
{
    [SerializeField]
    private Text finalScore;

    [SerializeField]
    private Text highScore;

    [SerializeField]
    private Text timesPlayedScore;

    [SerializeField]
    private Text responseTime;

    private void Start()
    {
        HighScorePerTimePlayed();

        finalScore.text = "" + Gameplay.score;

        timesPlayedScore.text = "" + Gameplay.gamesPlayed;

        ResponseTime();

        PlayerPrefs.Save();
    }

    public void LoadGameplayScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    private void HighScorePerTimePlayed()
    {
        switch (Timer.chosenTimeToPlay)
        {
            case Timer.timeToPlay.Five:
                if (Gameplay.score > PlayerPrefs.GetInt("5HighScore"))
                {
                    PlayerPrefs.SetInt("5HighScore", Gameplay.score);
                }
                highScore.text = "" + PlayerPrefs.GetInt("5HighScore");
                break;
            case Timer.timeToPlay.Ten:
                if (Gameplay.score > PlayerPrefs.GetInt("10HighScore"))
                {
                    PlayerPrefs.SetInt("10HighScore", Gameplay.score);
                }
                highScore.text = "" + PlayerPrefs.GetInt("10HighScore");
                break;
            case Timer.timeToPlay.Twenty:
                if (Gameplay.score > PlayerPrefs.GetInt("20HighScore"))
                {
                    PlayerPrefs.SetInt("20HighScore", Gameplay.score);
                }
                highScore.text = "" + PlayerPrefs.GetInt("20HighScore");
                break;
            case Timer.timeToPlay.Thirty:
                if (Gameplay.score > PlayerPrefs.GetInt("30HighScore"))
                {
                    PlayerPrefs.SetInt("30HighScore", Gameplay.score);
                }
                highScore.text = "" + PlayerPrefs.GetInt("30HighScore");
                break;
            case Timer.timeToPlay.Forty:
                if (Gameplay.score > PlayerPrefs.GetInt("40HighScore"))
                {
                    PlayerPrefs.SetInt("40HighScore", Gameplay.score);
                }
                highScore.text = "" + PlayerPrefs.GetInt("40HighScore");
                break;
            case Timer.timeToPlay.Fifty:
                if (Gameplay.score > PlayerPrefs.GetInt("50HighScore"))
                {
                    PlayerPrefs.SetInt("50HighScore", Gameplay.score);
                }
                highScore.text = "" + PlayerPrefs.GetInt("50HighScore");
                break;
            case Timer.timeToPlay.Sixty:
                if (Gameplay.score > PlayerPrefs.GetInt("60HighScore"))
                {
                    PlayerPrefs.SetInt("60HighScore", Gameplay.score);
                }
                highScore.text = "" + PlayerPrefs.GetInt("60HighScore");
                break;
            default:
                Debug.Log("Error, default time to play chosen.  No highscore");
                break;
        }
    }

    private void ResponseTime()
    {
        float rTime;

        switch (Timer.chosenTimeToPlay)
        {
            case Timer.timeToPlay.Five:
                rTime = 5f / Gameplay.score;
                break;
            case Timer.timeToPlay.Ten:
                rTime = 10f / Gameplay.score;
                break;
            case Timer.timeToPlay.Twenty:
                rTime = 20f / Gameplay.score;
                break;
            case Timer.timeToPlay.Thirty:
                rTime = 30f / Gameplay.score;
                break;
            case Timer.timeToPlay.Forty:
                rTime = 40f / Gameplay.score;
                break;
            case Timer.timeToPlay.Fifty:
                rTime = 50f / Gameplay.score;
                break;
            case Timer.timeToPlay.Sixty:
                rTime = 60f / Gameplay.score;
                break;
            default:
                rTime = 0;
                Debug.Log("Error, default time to play chosen.  No highscore");
                break;
        }

        responseTime.text = rTime.ToString("0.###");
    }
}
