using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Varrier : MonoBehaviour
{
    // 1. ������ �ִ� ����
        
    // 2. �ȿ� �ٸ� ��ü�� ������ ���
    
    // 3. "�� ����" �̶�� ����Ѵ�.
    private void OnTriggerEnter(Collider other)
    {
        // ����ǥ ǥ�ð� ���.
        Destroy(other.gameObject);

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
