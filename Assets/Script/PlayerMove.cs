using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 사용자가 원하는 방향으로 이동하고싶다.
// 사용자가 스페이스바를 누르면 점프하고싶다.
// 2번까지 점프하고싶다.

// 사용자가 z키를 누르면 "구르기"라고 출력된다.

// 사용자가 마우스 왼쪽 키를 누르면 "공격"이라고 출력된다.



// PlayerMove: 사용자의 입력에 따라 상하좌우로 이동하고 싶다.
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

        // 사용자가 z키를 누르면 "구르기"라고 출력된다.
        if (Input.GetKeyDown("z"))
        {
            print("구르기");
        }
        



        // 사용자가 마우스 왼쪽 키를 누르면 "공격"이라고 출력된다.
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("공격");
        }





        // 점프를 하고싶다.
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
