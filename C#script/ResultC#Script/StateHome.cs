using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// �z�[����ʂɑJ�ڂ���X�N���v�g<see cref="StateHome"/>
/// </summary>

public class StateHome : MonoBehaviour
{
    private bool TitleFlag;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        TitleFlag = true;
    }
    public void StateTitle()
    {
        if (TitleFlag)
        {
            SceneManager.LoadScene("TitleScene");
        }
        TitleFlag = false;
    }
}
