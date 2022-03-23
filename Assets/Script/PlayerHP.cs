using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 체력을 표현한다.
// 태어날때 최대체력을 만든다.
// 적에게 공격을 받았을 때 체력을 10씩 감소한다.

public class PlayerHP : MonoBehaviour
{
    public int maxHP = 100;
    int hp;

    public Slider sliderHP;
    public int HP
    {
        get { return hp; }
        set
        {
            hp = value;
            sliderHP.value = hp;
        }
    }    // Start is called before the first frame update
    void Start()
    {
        // 태어날 때 체력을 최대체력으로 하고싶다.
        sliderHP.maxValue = maxHP;
        HP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
