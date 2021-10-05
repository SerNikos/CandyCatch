using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject liveHolder;
    public GameObject gameOverPanel;

    int score;
    int lives = 3;
    public Text scoreText;

    bool gameover = false;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {
        if (!gameover)
        {
            score++; //we increment the score
            scoreText.text = score.ToString(); //and we convert it from int to text
        }
     
       
    }
    public void DecriseLife()
    {
        if (lives > 0)
        {
            lives--;
            liveHolder.transform.GetChild(lives).gameObject.SetActive(false);

        }
        else 
        {
            gameover = true;
            GameOver();
        }
        
    }
    public void GameOver()
    {
        print("GameOver");
        CandySpawner.instance.StopSpawningCandies();
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;
        gameOverPanel.SetActive(true);
    }
}
