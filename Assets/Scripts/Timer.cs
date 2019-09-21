using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public enum timeToPlay { Five, Ten, Twenty, Thirty, Forty, Fifty, Sixty };
    
    private float timeLeft;

    [SerializeField]
    private Text timeText;

    public static bool paused = false;

    public static timeToPlay chosenTimeToPlay;

    private void Start()
    {
        switch (chosenTimeToPlay)
        {
            case timeToPlay.Five:
                timeLeft = 5;
                break;
            case timeToPlay.Ten:
                timeLeft = 10;
                break;
            case timeToPlay.Twenty:
                timeLeft = 20;
                break;
            case timeToPlay.Thirty:
                timeLeft = 30;
                break;
            case timeToPlay.Forty:
                timeLeft = 40;
                break;
            case timeToPlay.Fifty:
                timeLeft = 50;
                break;
            case timeToPlay.Sixty:
                timeLeft = 60;
                break;
            default:
                timeLeft = 75;
                Debug.Log("Error, default time to play chosen");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = "" + (int)timeLeft;

        if (!paused)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                GamesPlayedPerTime();
                SceneManager.LoadScene(3); //EndScene
            }
        }
    }

    public void Pause()
    {
        paused = true;
    }

    public void Unpause()
    {
        paused = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    private void GamesPlayedPerTime()
    {
        switch (chosenTimeToPlay)
        {
            case timeToPlay.Five:
                Gameplay.gamesPlayed = PlayerPrefs.GetInt("Games5Played");
                Gameplay.gamesPlayed++;
                PlayerPrefs.SetInt("Games5Played", Gameplay.gamesPlayed);
                break;
            case timeToPlay.Ten:
                Gameplay.gamesPlayed = PlayerPrefs.GetInt("Games10Played");
                Gameplay.gamesPlayed++;
                PlayerPrefs.SetInt("Games10Played", Gameplay.gamesPlayed);
                break;
            case timeToPlay.Twenty:
                Gameplay.gamesPlayed = PlayerPrefs.GetInt("Games20Played");
                Gameplay.gamesPlayed++;
                PlayerPrefs.SetInt("Games20Played", Gameplay.gamesPlayed);
                break;
            case timeToPlay.Thirty:
                Gameplay.gamesPlayed = PlayerPrefs.GetInt("Games30Played");
                Gameplay.gamesPlayed++;
                PlayerPrefs.SetInt("Games30Played", Gameplay.gamesPlayed);
                break;
            case timeToPlay.Forty:
                Gameplay.gamesPlayed = PlayerPrefs.GetInt("Games40Played");
                Gameplay.gamesPlayed++;
                PlayerPrefs.SetInt("Games40Played", Gameplay.gamesPlayed);
                break;
            case timeToPlay.Fifty:
                Gameplay.gamesPlayed = PlayerPrefs.GetInt("Games50Played");
                Gameplay.gamesPlayed++;
                PlayerPrefs.SetInt("Games50Played", Gameplay.gamesPlayed);
                break;
            case timeToPlay.Sixty:
                Gameplay.gamesPlayed = PlayerPrefs.GetInt("Games60Played");
                Gameplay.gamesPlayed++;
                PlayerPrefs.SetInt("Games60Played", Gameplay.gamesPlayed);
                break;
            default:
                Debug.Log("Error, default time to play chosen");
                break;
        }
    }
}