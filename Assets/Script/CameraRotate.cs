using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 마우스를 움직인다
// 카메라가 마우스에 따라 회전한다.
public class CameraRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float rx;
    float ry;
    public float rotSpeed = 200;
    // Update is called once per frame
    void Update()
    {
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");

        rx = rx + my * rotSpeed * Time.deltaTime;
        ry = ry + mx * rotSpeed * Time.deltaTime;

        rx = Mathf.Clamp(rx, -70, 70);

        transform.eulerAngles = new Vector3(-rx, ry, 0);


        // 구르고 싶다.
        // 키워드를 누르면 앞으로 간다.
        //엎드려서 한 바퀴 구른다.
    }
}
