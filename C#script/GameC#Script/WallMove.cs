using TMPro;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// Wall�I�u�W�F�N�g�̈ړ��y�э폜�Ɋւ���v���O����<see cref="WallMove"/>
/// </summary>

public class WallMove : MonoBehaviour
{
    WallGenerator wallGenerator;

    private void Start()
    {
        wallGenerator=GameObject.Find("WallPrefabs").GetComponent<WallGenerator>();
    }
    void Update()
    {
        if (gameObject.activeSelf)
        {
            transform.position -= new Vector3(wallGenerator.Late * Time.deltaTime, 0, 0);
            if (gameObject.transform.position.x < -30)
            {
                Destroy(gameObject);
            }
        }
    }
}
