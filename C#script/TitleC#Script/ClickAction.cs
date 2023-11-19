using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ClickAction : MonoBehaviour
{
    private bool StartFlag;
    private bool How_to_PlayFlag;
    private bool TitleFlag;
    private void Start()
    {
        StartFlag = true;
        How_to_PlayFlag = true;
        TitleFlag = true;
    }

    // Update is called once per frame
    public void StateGame()
    {
        if (StartFlag)
        {
            SceneManager.LoadScene("GameScene");
            StartFlag=false;
        }
    }
    public void StateHow_to_Play()
    {
        if(How_to_PlayFlag)
        {
            SceneManager.LoadScene("How_to_PlayScene");
        }
    }
    public void StateTitle()
    {
        if(TitleFlag)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}