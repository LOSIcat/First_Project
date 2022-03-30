using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 90도 각도로 앞으로 나간다.
public class Sphere : MonoBehaviour
{





    public float speed = 5;
    Vector3 dir;


    // Start is called before the first frame update
    void Start()
    {


        int rValue = Random.Range(0, 10);
        if (rValue < 10)
        {
            GameObject target = GameObject.Find("Enemy");
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        //else if (GameObject =  null)
        //{
        //    return;
        //}




        //Vector3 dir;



        //적을 찾아 target으로 하고 싶다.
        //GameObject target = GameObject.Find("Enemy");
        //print("적");
        // 방향을 구하고 싶다. target-me
        // dir = target.transform.position - transform.position;
        // 방향의 크기를 1로 하고 싶다.
        // dir.Normalize();


    }
    //Vector3 target = new Vector3(3, 31, 0);


    //GameObject target = GameObject.Find("Enemy");





    // Update is called once per frame
    void Update()
    {



        //Vector3 dir = transform.forward;



        transform.position += dir * speed * Time.deltaTime;



        // 충돌체와 충돌하지 않는다면 3초 후에 파괴된다.

        //if (
        //    transform.position = )

        Destroy(gameObject, 3);

        //그렇지 않고 충돌한다면, 즉시 파괴된다.





        //transform.position = Vector3.MoveTowards(transform.position, target. Time.deltatime * 5)
    }
    //private void OnCollisionEnter(Collision collision)
    //{

    //    Destroy(collision.gameObject);
    //    print("적이죽는다");

    //    if (collision.gameObject.name.Contains("Enemy"))
    //    {
    //        //PlayerHP php = collision.gameObject.GetComponent<EnemyHP>();
    //        //php.HP--;

    //    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Enemy"))
        {

            Destroy(gameObject);
            EnemyHP ehp = collision.gameObject.GetComponent<EnemyHP>();
            ehp.HP--;
            if (ehp.HP <= 0)
            {
                Destroy(collision.gameObject);
            }
        }

    }
}


