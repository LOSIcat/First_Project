using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ����ڰ� ���ϴ� �������� �̵��ϰ�ʹ�.
// ����ڰ� �����̽��ٸ� ������ �����ϰ�ʹ�.
// 2������ �����ϰ�ʹ�.

// ����ڰ� zŰ�� ������ "������"��� ��µȴ�.

// ����ڰ� ���콺 ���� Ű�� ������ "����"�̶�� ��µȴ�.



// PlayerMove: ������� �Է¿� ���� �����¿�� �̵��ϰ� �ʹ�.
public class PlayerMove : MonoBehaviour
{
    CharacterController cc;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {



        cc = gameObject.GetComponent<CharacterController>();



    }

    public float jumpPower = 6;
    public float gravity = -9.8f;
    float yVelocity;

    int jumpCount;
    public int maxJumpCount = 2;


    // Update is called once per frame
    void Update()
    {

        // ����ڰ� zŰ�� ������ "������"��� ��µȴ�.
        if (Input.GetKeyDown("z"))
        {
            print("������");
        }
        



        // ����ڰ� ���콺 ���� Ű�� ������ "����"�̶�� ��µȴ�.
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("����");
        }





        // ������ �ϰ�ʹ�.
        if (cc.isGrounded)
        {
            jumpCount = 0;

        }
        else
        {
            yVelocity += gravity * Time.deltaTime;
        }


        if (jumpCount < maxJumpCount && Input.GetButtonDown("Jump"))
        {
            yVelocity = jumpPower;
            jumpCount++;
        }




        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);


        transform.position = transform.position + dir * speed * Time.deltaTime;

        dir = Camera.main.transform.TransformDirection(dir);
        dir.y = 0;
        dir.Normalize();
        Vector3 velocity = dir * speed;

        velocity.y = yVelocity;

        cc.Move(velocity * Time.deltaTime);

    }
}
