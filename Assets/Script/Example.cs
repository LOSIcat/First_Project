using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{

    int Plus(int a, int b)
    {
        int result = a + b;
        return result;
    }

    // Start is called before the first frame update
    void Start()
    {
            int number = 100;
            for (int i = 0; i < 1; i++)
            {
                number = number + 10;
            print(number);
        }
            
        

    }

    // Update is called once per frame
    void Update()
    {
        int sum = Plus(2, 10);
        print(sum);
    }
}
