using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ü���� ǥ���Ѵ�.
// �¾�� �ִ�ü���� �����.
// ������ ������ �޾��� �� ü���� 10�� �����Ѵ�.

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
        // �¾ �� ü���� �ִ�ü������ �ϰ�ʹ�.
        sliderHP.maxValue = maxHP;
        HP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
