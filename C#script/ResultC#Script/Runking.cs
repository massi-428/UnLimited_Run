/*using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

/*public class Runking : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI No1_Text;
    [SerializeField] TextMeshProUGUI No2_Text;
    [SerializeField] TextMeshProUGUI No3_Text;
    [SerializeField] private GameObject No1;
    [SerializeField] private GameObject No2;
    [SerializeField] private GameObject No3;
    GameScore gameScore;
    PlayerJump playerJump;
    private bool Once;
    private int[] reset={0,0};
    private static List<int> ScoreList=new List<int>();
    // Start is called before the first frame update
    private void Start()
    {
        Once = true;
        ScoreList.AddRange(reset);
        gameScore=GameObject.Find("ScoreBoard").GetComponent<GameScore>();
        playerJump=GameObject.Find("Charactor").GetComponent<PlayerJump>();
    }
    void Update()
    {
        if(playerJump.Player.position.x<-15)
        {
            if(Once)
            {
                ScoreList.Add(gameScore.ResultScore);
                ScoreList.Sort();
                ScoreList.Reverse();
                Debug.Log(ScoreList.Count);
                Once = false;
            }
        }
        No1_Text.text = ScoreList[0].ToString();
        if (ScoreList.Count >= 2)
        {
            No2.SetActive(true);
            No2_Text.text = ScoreList[1].ToString();
        }
        if (ScoreList.Count >= 3)
        {
            No3.SetActive(true);
            No3_Text.text = ScoreList[2].ToString();
        }
        if (ScoreList.Count > 4)
        {
            ScoreList.Remove(ScoreList[4]);
        }
    }


public class Ranking : MonoBehaviour
{

    [SerializeField, Header("���l")]
    int point;

    string[] ranking = { "1��", "2��", "3��"};
    int[] rankingValue = new int[3];

    [SerializeField, Header("�\��������e�L�X�g")]
    private TextMeshProUGUI rankingText = new TextMeshProUGUI;

    // Use this for initialization
    void Start()
    {
        GetRanking();

        SetRanking(point);

        for (int i = 0; i < rankingText.count; i++)
        {
            rankingText[i].text = rankingValue[i].ToString();
        }
    }

    /// <summary>
    /// �����L���O�Ăяo��
    /// </summary>
    void GetRanking()
    {
        //�����L���O�Ăяo��
        for (int i = 0; i < ranking.Length; i++)
        {
            rankingValue[i] = PlayerPrefs.GetInt(ranking[i]);
        }
    }
    /// <summary>
    /// �����L���O��������
    /// </summary>
    void SetRanking(int _value)
    {
        //�������ݗp
        for (int i = 0; i < ranking.Length; i++)
        {
            //�擾�����l��Ranking�̒l���r���ē���ւ�
            if (_value > rankingValue[i])
            {
                var change = rankingValue[i];
                rankingValue[i] = _value;
                _value = change;
            }
        }

        //����ւ����l��ۑ�
        for (int i = 0; i < ranking.Length; i++)
        {
            PlayerPrefs.SetInt(ranking[i], rankingValue[i]);
        }
    }
}*/