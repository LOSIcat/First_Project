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
   // �浹 ���۵Ǹ�
    // private void oncollisionenter(collision collision)
    //{
    //    print("hello");
    //    // enemy�� �浹�ϴ� ����
    //    // enmey�� �װ�, shpere�� �������
    //    if (collision.gameobject)
    //    {
    //        // �� �װ�
    //        destroy(collision.gameobject);
    //        // �� ����
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
