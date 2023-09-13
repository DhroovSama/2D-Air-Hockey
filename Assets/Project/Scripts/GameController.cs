using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Puck puck;
    public Text scoreText;

    private int score1;
    private int score2;

    private bool isGameOver;
    private float resetTimer=3f;

    // Start is called before the first frame update
    void Start()
    {
        puck.OnGoal += OnGoal;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver == true)
        {
            resetTimer -= Time.deltaTime;
            if(resetTimer <=0){
                SceneManager.LoadScene("SampleScene");
            }
        }

    }
    void OnGoal()
    {
        Debug.Log("Goal!!!");
        if (puck.transform.position.x>0)
        {
            score1++;
            puck.resetPosition(false);
        } else{
            score2++;
            puck.resetPosition(true);
        }
        scoreText.text = score1 + ":" + score2; 

        if(score1 == 5){
            scoreText.text = "Player 1 wins!";
            puck.gameObject.SetActive(false);
            isGameOver=true;
        } 
        else if (score2 == 5)
        {
            scoreText.text = "Player 2 wins!";
            puck.gameObject.SetActive(false);
            isGameOver=true;
        }
    }
}
