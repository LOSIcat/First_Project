using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Varrier : MonoBehaviour
{
    // 1. 범위가 있는 영역
        
    // 2. 안에 다른 물체가 감지될 경우
    
    // 3. "적 출현" 이라고 출력한다.
    private void OnTriggerEnter(Collider other)
    {
        // 느낌표 표시가 뜬다.
        Destroy(other.gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
