using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power_Manager : MonoBehaviour
{
    public EnnemyOnScene enemy;
    private int dmg_power;

    public void Power_Explosion()
    {
        //enemy = FindObjectOfType<EnnemyOnScene>();
        dmg_power = enemy.max_HP_cur;
        enemy.Dammage(dmg_power);

    }
}
