using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour
{
    public enum level { LevelOne, LevelTwo, LevelThree };

    [SerializeField]
    private GameObject myPrefab;
    private RectTransform myPrefabTransform;

    [SerializeField]
    private GameObject canvas;
    private RectTransform canvasTransform;

    [SerializeField]
    private GameObject level2Balls;

    [SerializeField]
    private GameObject level3Balls;

    [SerializeField]
    private RectTransform topCanvasBarTransform;

    private Vector3 position;

    [SerializeField]
    private Text scoreText;
    public static int score;

    [SerializeField]
    private Animator[] distractionAnims = new Animator[8];

    public static int gamesPlayed;

    public static level levelChoice;

    // Start is called before the first frame update
    void Start()
    {
        switch (levelChoice)
        {
            case level.LevelOne:
                level2Balls.SetActive(false);
                level3Balls.SetActive(false);
                break;
            case level.LevelTwo:
                level2Balls.SetActive(true);
                level3Balls.SetActive(false);
                break;
            case level.LevelThree:
                level2Balls.SetActive(true);
                level3Balls.SetActive(true);
                break;
            default:
                Debug.Log("Error, level not chosen.  Default level: Level 1");
                level2Balls.SetActive(false);
                level3Balls.SetActive(false);
                break;
        }

        canvasTransform = canvas.GetComponent<RectTransform>();
        myPrefabTransform = myPrefab.GetComponent<RectTransform>();

        score = 0;

        NewPosition();

        // Instantiate prefab at position and zero rotation.
        GameObject prefabInstance = GameObject.Instantiate(myPrefab, position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + score;

        if (!Timer.paused)
        {
            foreach(Animator a in distractionAnims)
            {
                a.speed = 1;
            }
        }
        else
        {
            foreach (Animator a in distractionAnims)
            {
                a.speed = 0;
            }
        }

    }

    //generates a new position within the canvas
    public void NewPosition()
    {
        position = new Vector3(Random.Range((-1 *((canvasTransform.rect.width - myPrefabTransform.rect.width)/2)) + canvas.transform.position.x, 
            ((canvasTransform.rect.width - myPrefabTransform.rect.width) / 2) + canvas.transform.position.x), 
            Random.Range((-1 * ((canvasTransform.rect.height - myPrefabTransform.rect.height) / 2)) + canvas.transform.position.y,
            ((canvasTransform.rect.height - myPrefabTransform.rect.height) / 2) + canvas.transform.position.y - topCanvasBarTransform.rect.height), 
            0);
    }

    public void NewSpawn()
    {
        Debug.Log("New Prefab Spawn");
        GameObject prefabInstance = GameObject.Instantiate(myPrefab, position, Quaternion.identity, canvas.transform);
    }

    public void ReturntoStartScene()
    {
        SceneManager.LoadScene(0);
    }

}
