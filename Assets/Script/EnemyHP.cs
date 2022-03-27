using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHP : MonoBehaviour
{
    public int maxHp = 3;
    int hp;

    public Slider SliderHP;

    public int HP
    {
        get { return hp; }
        set
        {
         
            hp = value;
            SliderHP.value = hp;
        }
    }

   

    // Start is called before the first
    // gframe update
    void Start()
    {
        SliderHP.maxValue = maxHp;
          HP = maxHp;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
