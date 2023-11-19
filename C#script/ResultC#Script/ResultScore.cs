using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResultScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ResultText;
    private bool Once;
    GameScore gameScore;
    PlayerJump playerJump;
    // Start is called before the first frame update
    void Start()
    {
        Once = true;
        gameScore=GameObject.Find("ScoreBoard").GetComponent<GameScore>();
        playerJump=GameObject.Find("Charactor").GetComponent<PlayerJump>();
    }
    private void Update()
    {
        if(Once)
        {
            if (playerJump.Player.position.x < -10)
                ResultText.text = gameScore.ResultScore.ToString();
        }
    }
}
