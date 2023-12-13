using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnnemyOnScene : MonoBehaviour
{
    public int cur_HP;

    public int max_HP_cur;

    public Image health_bar_fill;

    public Data_Enemy[] enemy_to_spawn;

    private Data_Enemy cur_enemy;

    public Image sprite_enemy;

    public GameObject[] enemy_prefab;

    public Transform canvas;

    public Score_Manger score_joueur;

    private void Start()
    {
        Read_Enemy();

    }

    public void Read_Enemy()
    {
        cur_enemy = enemy_to_spawn[Random.Range(0, enemy_to_spawn.Length)];
        sprite_enemy.sprite = cur_enemy.sprite_enemy;
        cur_HP = cur_enemy.max_HP;
        FeedbackHealthbar();
    }

    public void Dammage(int amount)
    {
        cur_HP-= amount;
        FeedbackHealthbar();
        score_joueur.score_joueur += (amount);

        if (cur_HP <= 0)
        {
            Caught();
        }
    }
    public void Dammage()
    {
        Dammage(1);
    }

    public void FeedbackHealthbar()
    {
        health_bar_fill.fillAmount = (float)cur_HP / (float)cur_enemy.max_HP;
    }

    public void Caught()
    {
        Game_Manager.instance.add_money(cur_enemy.money_drop);
        Read_Enemy();
        //Debug.Log("hehe");
        if (Random.Range(1,100) >= 99)
        {
            Game_Manager.instance.add_money_gatcha(cur_enemy.money_drop);
        }
    }

    private void Update()
    {
        max_HP_cur = cur_enemy.max_HP;
    }

}
