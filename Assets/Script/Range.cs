using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range : MonoBehaviour
{

    // 1. ������ �ִ� ����
    private void OnCollisionEnter(Collision collision)
    {
        print("crash");

        // 2. �ȿ� �ٸ� ��ü�� ������ ���
        // 3. "�� ����" �̶�� ����Ѵ�.
    }
    private void OnCollisionExit(Collision collision)
    {
        print("������");
    }

    private void OnCollisionStay(Collision collision)
    {
        print("���");
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
