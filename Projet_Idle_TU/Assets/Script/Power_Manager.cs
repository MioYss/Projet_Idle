using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power_Manager : MonoBehaviour
{
    public EnnemyOnScene enemy;

    public void Power_Explosion()
    {
        //enemy = FindObjectOfType<EnnemyOnScene>();
        enemy.cur_HP -= 15;
        enemy.FeedbackHealthbar();

        if (enemy.cur_HP <= 0)
        {
            enemy.Caught();
        }

    }
}
