using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5;

    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {


        //int randValute = UnityEngine.Random.Range(0, 10);
        //if (randValute < 3)
        //{
        //    GameObject target = GameObject.Find("Player");

        //    dir = target.transform.position - transform.position;
        //    dir.Normalize();
        //}
        //else
        //{
        //    dir = Vector3.forward;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += dir * speed * Time.deltaTime;
    }
   // 충돌 시작되면
    // private void oncollisionenter(collision collision)
    //{
    //    print("hello");
    //    // enemy가 충돌하는 순간
    //    // enmey도 죽고, shpere도 사라진다
    //    if (collision.gameobject)
    //    {
    //        // 너 죽고
    //        destroy(collision.gameobject);
    //        // 나 죽자
    //        destroy(gameobject);
    //    }

    //}
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name.Contains("sphere"))
    //    {
    //        EnemyHP ehp = GetComponent<EnemyHP>();
    //        ehp.HP--;
    //        if (ehp.HP <= 0)
    //        {
    //            Destroy(collision.gameObject);
    //        }
    //    }
    //}


}
