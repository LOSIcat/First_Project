using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMagic : MonoBehaviour
{    // 구를 생산할 공장
    public GameObject sphereFactory;
    // 구 생성하는 곳
    public GameObject spherePosition;
    public GameObject spherePosition1;
    public GameObject spherePosition2;
    // Start is called before the first frame update
    void Start()
    {






    }

    // Update is called once per frame
    void Update()
    {
        // 플레이어 앞에서 "F"키를 누르면 구가 출력된다.
        if (Input.GetKeyDown(KeyCode.F))
        {
            // 구 공장에서 구를 만든다.
            GameObject sphere = Instantiate(sphereFactory);
            // 구가 앞으로 나간다.
            sphere.transform.position = spherePosition.transform.position;

            
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            // 구 공장에서 구를 만든다.
            GameObject sphere = Instantiate(sphereFactory);
            // 구가 앞으로 나간다.
            sphere.transform.position = spherePosition1.transform.position;

        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            // 구 공장에서 구를 만든다.
            GameObject sphere = Instantiate(sphereFactory);
            // 구가 앞으로 나간다.
            sphere.transform.position = spherePosition2.transform.position;

        }

        //// 플레이어가 마우스 왼쪽 버튼을 누르면 "어택"이 입력된다.
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("어택");
        //}



    }
}