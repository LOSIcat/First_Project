using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMagic : MonoBehaviour
{
    public GameObject magicPosition;
    // Start is called before the first frame update
    void Start()
    {
        //if (Input.GetKeyDown(KeyCode.F))
        //{
           
        //}
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(gameObject.transform.position, magicPosition.transform.position, 0.5f);
    }
}
