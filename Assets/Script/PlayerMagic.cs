using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMagic : MonoBehaviour
{    // ���� ������ ����
    public GameObject sphereFactory;
    // �� �����ϴ� ��
    public GameObject spherePosition;
    // Start is called before the first frame update
    void Start()
    {






    }

    // Update is called once per frame
    void Update()
    {
        // �÷��̾� �տ��� "F"Ű�� ������ ���� ��µȴ�.
        if (Input.GetKeyDown(KeyCode.F))
        {
            // �� ���忡�� ���� �����.
            GameObject sphere = Instantiate(sphereFactory);
            // ���� ������ ������.
            sphere.transform.position = spherePosition.transform.position;


        }
    }
}