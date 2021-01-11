using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Text gameOverText;
    public Button reGame;

    int score = 0;
    public bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        gameOverText.gameObject.SetActive(false);
        reGame.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + score;
        if (isGameOver)
        {
            Time.timeScale = 0;
            gameOverText.gameObject.SetActive(true);
            reGame.gameObject.SetActive(true);
        }
       
    }
    public void AddScore()
    {
        score++;    
    }

    public void ClickButton()
    {
        SceneManager.LoadScene(0);
 
    }

}


