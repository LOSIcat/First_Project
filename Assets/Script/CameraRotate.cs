using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���콺�� �����δ�
// ī�޶� ���콺�� ���� ȸ���Ѵ�.
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


        // ������ �ʹ�.
        // Ű���带 ������ ������ ����.
        //������� �� ���� ������.
    }
}
