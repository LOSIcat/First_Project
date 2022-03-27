using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range : MonoBehaviour
{

    // 1. 범위가 있는 영역
    private void OnCollisionEnter(Collision collision)
    {
        print("crash");

        // 2. 안에 다른 물체가 감지될 경우
        // 3. "적 출현" 이라고 출력한다.
    }
    private void OnCollisionExit(Collision collision)
    {
        print("나갈때");
    }

    private void OnCollisionStay(Collision collision)
    {
        print("계속");
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
}
