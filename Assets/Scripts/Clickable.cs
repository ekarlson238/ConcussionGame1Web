using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clickable : MonoBehaviour
{
    private Gameplay gameplay;

    private GameObject gameManager;

    private Button myselfButton;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");

        if (gameplay == null)
        {
            gameplay = gameManager.GetComponent(typeof(Gameplay)) as Gameplay;
        }

        myselfButton = GetComponent<Button>();
        myselfButton.onClick.AddListener(() => Clicked());
    }

    // Places the prefab at a new random spot and add to the score
    public void Clicked()
    {
        if (!Timer.paused)
        {
            Gameplay.score++;

            gameplay.NewPosition();

            gameplay.NewSpawn();

            Destroy(this.gameObject);
        }
    }

}
