using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int cur_HP;

    public int max_HP;

    public int money_drop;

    public Image health_bar_fill;

    public void Dammage()
    {
        cur_HP--;
        health_bar_fill.fillAmount = (float)cur_HP / (float)max_HP;

        if(cur_HP<= 0)
        {
            Caught();
        }
    }

    public void Caught()
    {
        Game_Manager.instance.add_money(money_drop);
        Enemy_Manager.instance.Replace_Enemy(gameObject);
        //Debug.Log("hehe");
        if (Random.Range(1,100) >= 99)
        {
            Game_Manager.instance.add_money_gatcha(money_drop);
        }
    }
}
