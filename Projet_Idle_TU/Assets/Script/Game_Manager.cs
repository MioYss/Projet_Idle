using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game_Manager : MonoBehaviour
{
    public int money;

    public TextMeshProUGUI money_text;

    public static Game_Manager instance;

    void Awake()
    {
        instance = this;
    }

    public void add_money(int amount)
    {
        money += amount;
        money_text.text = "€" + money.ToString();
    }

    public void take_money(int amount)
    {
        money -= amount;
        money_text.text = "€" + money.ToString();
    }
}
