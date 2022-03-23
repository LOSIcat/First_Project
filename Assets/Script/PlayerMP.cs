using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ������ ǥ���Ѵ�.
// �¾�� �ִ� ������ �����.
// �ϳ��� ����� ����� �� ���� 10�� �����Ѵ�.
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
