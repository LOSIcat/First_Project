using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 마력을 표현한다.
// 태어날때 최대 마력을 만든다.
// 하나의 기술을 사용할 때 마력 10씩 감소한다.
public class PlayerMP : MonoBehaviour
{
    public int maxMP = 100;
    int mp;

    public Slider sliderMP;

    public int MP
    {
        get { return mp; }
        set
        {
            mp = value;
            sliderMP.value = mp;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        sliderMP.maxValue = maxMP;
        MP = maxMP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
