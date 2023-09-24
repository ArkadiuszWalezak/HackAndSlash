using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesCounter : MonoBehaviour
{
    [SerializeField] public Text counter;
    [SerializeField] public Text GameOverText;
    //public int PlayerLivesCount { get { return playerLivesCount; } }
    public int playerLivesCount = 3;


    void Start()
    {
        SubtractLive();
    }

    public void SubtractLive()
    {
        counter.text = playerLivesCount.ToString();
    }

    public void GameOver()
    {
        GameOverText.text = "Game Over";
    }

    public void Death()
    {
        playerLivesCount--;
    }

    public int ReturnLives()
    {
        return playerLivesCount;
    }
}
