using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back_to_Click : MonoBehaviour
{
    private bool BackFlag;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        BackFlag = true;
    }
    public void StateTttleScene()
    {
        if(BackFlag)
        {
            SceneManager.LoadScene("TitleScene");
            BackFlag = false;
        }
    }

}
