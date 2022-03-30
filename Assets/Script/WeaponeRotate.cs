using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponeRotate : MonoBehaviour
{
    //public float weaponRotateSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {

    }


    float rx;
    float ry;
    public float rotSpeed = 100;

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.forward, weaponRotateSpeed * Time.deltaTime);

       

        // 1. 사용자가 왼쪽 마우스 키를 누르면
        if (Input.GetMouseButtonDown(0))
        {
            // 2. 무기가 회전한다.


        }


    }
}
