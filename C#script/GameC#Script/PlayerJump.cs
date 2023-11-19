using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using UnityEngine;

/// <summary>
/// プレイヤーのジャンプに関するスクリプト <see cref="PlayerJump"/>
/// </summary>
public class PlayerJump : MonoBehaviour
{
    [SerializeField] public Rigidbody2D Player;
    public float JumpPower;
    [SerializeField] Animator animator;
    private static int JUMP = Animator.StringToHash("Jump");
    private static int RUN = Animator.StringToHash("Run");
    private static bool JumpFlag = true;
    [SerializeField] private string gameObjectName;
    [SerializeField] private GameObject ResultDisplay;

    private void Start()
    {
        ResultDisplay.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {   
            gameObjectName = collision.gameObject.name;
       
        switch(gameObjectName)
        {
            case "Ground":
                animator.SetBool(RUN, true);
                animator.SetBool(JUMP, false);
                if (Player.position.y > 2.1)
                {
                    JumpFlag = false;
                }
                else
                {
                    JumpFlag = true;
                }
                break;
            case "_UpperWall":
                animator.SetBool(RUN, true);
                animator.SetBool(JUMP, false);
                JumpFlag = false;
                break;
            case "_UnderWall":
                animator.SetBool(RUN, true);
                animator.SetBool(JUMP, false);
                if(Player.position.y>2.1)
                {
                    JumpFlag = false;
                }
                else
                {
                    JumpFlag = true;
                }
                break;
            case "_LargeUnderWall":
                animator.SetBool(RUN, true);
                animator.SetBool(JUMP, false);
                if (Player.position.y > 2.1)
                {
                    JumpFlag = false;
                }
                else
                {
                    JumpFlag = true;
                }
                break;
            case "_MiniUnderWall":
                animator.SetBool(RUN, true);
                animator.SetBool(JUMP, false);
                if (Player.position.y > 2.1)
                {
                    JumpFlag = false;
                }
                else
                {
                    JumpFlag = true;
                }
                break;
            case null:
                animator.SetBool(RUN, false);
                animator.SetBool(JUMP, true);
                JumpFlag = false;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.x < -8)
        {
            Player.transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
        }
        //ジャンプのフラグ及びジャンプの動作の実装
        if (JumpFlag)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Player.velocity = Vector2.up * JumpPower;
                //二段ジャンプの禁止の実装
                JumpFlag = false;
            }
        }
        if(Player.transform.position.x<-10)
        {
            ResultDisplay.SetActive(true);
        }
    }
}