using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game_Manager : MonoBehaviour
{
    public int money;

    public int enemy_dead ;

    public int last_number_enemy ;

    public int money_gatcha;

    public Gatcha_Manager oods;

    public TextMeshProUGUI money_text;

    public TextMeshProUGUI money_gatcha_text;

    public static Game_Manager instance;

    void Awake()
    {
        instance = this;
    }

    public void Add_money(int amount)
    {
        money += amount;
        money_text.text = "€" + money.ToString();
        enemy_dead ++;
        oods.Up_oods_gatcha();
    }

    public void Take_money(int amount)
    {
        money -= amount;
        money_text.text = "€" + money.ToString();
    }

    public void Add_money_gatcha(int amout)
    {
        money_gatcha += amout;
        money_gatcha_text.text = "C" + money_gatcha.ToString();
    }

    public void Take_money_gatcha(int amout)
    {
        money_gatcha -= amout;
        money_gatcha_text.text = "C" + money_gatcha.ToString();
    }

    private void Keep_last_number_enemy_dead()
    {
        last_number_enemy = enemy_dead;
    }

    private void Update()
    {
        Keep_last_number_enemy_dead();

    }

    public void Show_Gatcha()
    {

    }
}
