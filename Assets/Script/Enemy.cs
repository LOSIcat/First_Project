using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // 충돌 시작되면
    private void OnCollisionEnter(Collision collision)
    {
       /* print("hello");
   // enemy가 충돌하는 순간
   // enmey도 죽고, shpere도 사라진다
        if (collision.gameObject)
        {
            // 너 죽고
            Destroy(collision.gameObject);
            // 나 죽자
            Destroy(gameObject);
        }*/

    }
}
