using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetupSceneManager : MonoBehaviour
{
    public void ChooseLevelOne()
    {
        Gameplay.levelChoice = Gameplay.level.LevelOne;
    }

    public void ChooseLevelTwo()
    {
        Gameplay.levelChoice = Gameplay.level.LevelTwo;
    }

    public void ChooseLevelThree()
    {
        Gameplay.levelChoice = Gameplay.level.LevelThree;
    }

    public void ChooseTime5()
    {
        Timer.chosenTimeToPlay = Timer.timeToPlay.Five;
    }

    public void ChooseTime10()
    {
        Timer.chosenTimeToPlay = Timer.timeToPlay.Ten;
    }

    public void ChooseTime20()
    {
        Timer.chosenTimeToPlay = Timer.timeToPlay.Twenty;
    }

    public void ChooseTime30()
    {
        Timer.chosenTimeToPlay = Timer.timeToPlay.Thirty;
    }

    public void ChooseTime40()
    {
        Timer.chosenTimeToPlay = Timer.timeToPlay.Forty;
    }

    public void ChooseTime50()
    {
        Timer.chosenTimeToPlay = Timer.timeToPlay.Fifty;
    }

    public void ChooseTime60()
    {
        Timer.chosenTimeToPlay = Timer.timeToPlay.Sixty;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(2); //gameplay
    }
}
