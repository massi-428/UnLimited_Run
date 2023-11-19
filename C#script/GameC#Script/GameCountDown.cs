using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class GameCountDown : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI CountDown;
    [SerializeField] GameObject CountDownParent;
    public static bool EndFlag;
    // Start is called before the first frame update
    void Start()
    {
        EndFlag = false;
        StartCoroutine(CountDownCorutine(CountDown));
        CountDownParent.SetActive(true);
        Time.timeScale = 0;
    }
    private IEnumerator CountDownCorutine(TextMeshProUGUI gameObject)
    {
        for(int i = 3;i>=0;i--)
        {
            yield return new WaitForSecondsRealtime(1);
            gameObject.text = i.ToString();
        }
        Time.timeScale = 1;
        CountDownParent.SetActive(false);
        EndFlag = true;
    }
}
