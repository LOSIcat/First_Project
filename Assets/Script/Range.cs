using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range : MonoBehaviour
{

    // 1. ������ �ִ� ����
    private void OnTriggerEnter(Collider other)
    {    // 2. �ȿ� �ٸ� ��ü�� ������ ���
        // 3. "�� ����" �̶�� ����Ѵ�.
        print("crash");
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
