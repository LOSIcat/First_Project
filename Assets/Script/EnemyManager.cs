using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    // ����ð�
    float currentTime;
    // �����ð�
    public float createTime = 1;
    // �� ����
    public GameObject enemyFactory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �ð��� �帣�ٰ�
        currentTime += Time.deltaTime;
        // ���� ���� �ð��� �����ð��� �Ǹ�
        if (currentTime > createTime) 
        {
            // �����忡�� ���� ����
            GameObject enemy = Instantiate(enemyFactory);
            // �� ��ġ�� ������ ����ʹ�.
            enemy.transform.position = transform.position;
        }
       currentTime = 0;
    }
}
