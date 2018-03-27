using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{

    public float resetDelay = 1f;
    public GUIText pauseText;
    public GUIText gameOverText;
    public GUIText restartText;
    public GUIText scoreText;
    public GameObject player = null;
    public static GM instance = null;
    public int jellyBeans = 5;
    public AudioSource deathMusic;

    [HideInInspector] public bool gameOver;
    private bool restart;
    private int score;
    
    void Start()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        pauseText.text = "Press 'P' to pause";
        score = 0;
        UpdateScore();
        
    }

    // Use this for initialization
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

    }

    void Update()
    {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    public void Setup()
    {
        if (player == null)
            player = Instantiate(player, transform.position, Quaternion.identity) as GameObject;

    }

    public void AddScore (int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
        Destroy(pauseText);
        restartText.text = "Press 'R' to Restart";
        restart = true;
    }
}