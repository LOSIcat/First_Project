using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 90�� ������ ������ ������.
public class Sphere : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = transform.forward;

        transform.position += dir * speed * Time.deltaTime;

        Destroy(gameObject, 3) ;
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        Destroy(collision.gameObject);
        print("�����״´�");
    }
}
