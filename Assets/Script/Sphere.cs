using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 90�� ������ ������ ������.
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



        //���� ã�� target���� �ϰ� �ʹ�.
        //GameObject target = GameObject.Find("Enemy");
        //print("��");
        // ������ ���ϰ� �ʹ�. target-me
        // dir = target.transform.position - transform.position;
        // ������ ũ�⸦ 1�� �ϰ� �ʹ�.
        // dir.Normalize();


    }
    //Vector3 target = new Vector3(3, 31, 0);


    //GameObject target = GameObject.Find("Enemy");





    // Update is called once per frame
    void Update()
    {



        //Vector3 dir = transform.forward;



        transform.position += dir * speed * Time.deltaTime;



        // �浹ü�� �浹���� �ʴ´ٸ� 3�� �Ŀ� �ı��ȴ�.

        //if (
        //    transform.position = )

        Destroy(gameObject, 3);

        //�׷��� �ʰ� �浹�Ѵٸ�, ��� �ı��ȴ�.





        //transform.position = Vector3.MoveTowards(transform.position, target. Time.deltatime * 5)
    }
    //private void OnCollisionEnter(Collision collision)
    //{

    //    Destroy(collision.gameObject);
    //    print("�����״´�");

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


