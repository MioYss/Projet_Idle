using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Auto_Clicker_Manager : MonoBehaviour
{
    public List<float> auto_clicker = new List<float>();

    public int auto_clicker_price;

    public TextMeshProUGUI quantity_text;


    void Update()
    {
        //Loop entre les auto click
        for (int i = 0; i < auto_clicker.Count; i++)
        {
            if(Time.time - auto_clicker[i] >= 1.0f)
            {
                auto_clicker[i] = Time.time;
                Enemy_Manager.instance.cur_enemy.Dammage();
            }
        }
    }

    public void On_Buy_Auto_Clicker()
    {
        if(Game_Manager.instance.money >= auto_clicker_price)
        {
            Game_Manager.instance.take_money(auto_clicker_price);
            auto_clicker.Add(Time.time);

            quantity_text.text = "X" + auto_clicker.Count.ToString();
        }
    }
}
