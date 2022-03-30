using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    // 현재시간
    float currentTime;
    // 일정시간
    public float createTime = 1;
    // 적 공장
    public GameObject enemyFactory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 시간이 흐르다가
        currentTime += Time.deltaTime;
        // 만약 현재 시간이 일정시간이 되면
        if (currentTime > createTime) 
        {
            // 적공장에서 적을 만들어서
            GameObject enemy = Instantiate(enemyFactory);
            // 내 위치에 가져다 놓고싶다.
            enemy.transform.position = transform.position;
        }
       currentTime = 0;
    }
}
