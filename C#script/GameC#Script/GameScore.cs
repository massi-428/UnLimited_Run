using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SocialPlatforms.Impl;

public class GameScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreBoard;
    public int Score;
    public int ResultScore;
    private bool Once;
    GameCountDown gameCountDown;
    PlayerJump playerJump;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        Once = true;
        Score = 0;
        playerJump=GameObject.Find("Charactor").GetComponent<PlayerJump>();
        gameCountDown=GameObject.Find("CountDown").GetComponent<GameCountDown>();
        ScoreBoard.text = "Score:" + Score;
    }
    void Update()
    {
        if(GameCountDown.EndFlag)
        {
            Score += 1;
            ScoreBoard.text = "Score:" + Score;
        }
        if(playerJump.Player.position.x < -10)
        {
            if (Once)
            {
                ResultScore = Score;
                Once = false;
            }
        }
    }
}
