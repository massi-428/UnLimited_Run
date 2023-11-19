using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Wallオブジェクトの生成に関するプログラム<see cref="WallGenerator"/>
/// </summary>

public class WallGenerator : MonoBehaviour
{
    [SerializeField] GameObject UpperWall;
    [SerializeField] GameObject UpperWall1;
    [SerializeField] GameObject UnderWall;
    [SerializeField] GameObject Large_UnderWall;
    [SerializeField] GameObject Mini_UnderWall;
    [SerializeField] GameObject ScoreObject;
    [SerializeField] private float maxTime = 1.0f;
    [SerializeField] private float minTime = 1.5f;
    public float Late;
    private int GameSpeed;
    private bool SpeedFlag;
    GameScore gameScore;
    GameCountDown gameCountDown;


    // Start is called before the first frame update
    void Start()
    {
        gameScore=GameObject.Find("ScoreBoard").GetComponent<GameScore>();
        gameCountDown = GameObject.Find("CountDown").GetComponent <GameCountDown>();
        StartCoroutine(GenerateWall(UpperWall, 5));
        StartCoroutine(GenerateWall(UnderWall, 0));
        StartCoroutine(GenerateWall(Large_UnderWall, 0));
        StartCoroutine(GenerateWall(Mini_UnderWall, 0));
        Late = 10f;
        SpeedFlag = false;
        StartCoroutine(GameSpeedChanger());
    }

    private void Update()
    {
        Debug.Log(Late);
        if (SpeedFlag)
        {
            Late =Late+GameSpeed;
            SpeedFlag = false;
        }
    }

    private IEnumerator GenerateWall(GameObject gameObject, float y)
    {
        while (true) 
        {
            yield return new WaitForSeconds(GetRandomTime());
            Instantiate(gameObject, new Vector2(15, y), Quaternion.identity);
        }
    }
    private float GetRandomTime()
    {
        return Random.Range(maxTime, minTime);
    }
    private IEnumerator GameSpeedChanger()
    {
        for(int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(10);
            if (maxTime <= 0)
            {
                maxTime -= 0.2f;
            }
            if (minTime <= 0)
            {
                minTime -= 0.3f;
            }
            GameSpeed+=3;
            SpeedFlag=true;
        }
    }
} 
