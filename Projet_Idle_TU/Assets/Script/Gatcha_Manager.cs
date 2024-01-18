using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gatcha_Manager : MonoBehaviour
{

    public WeightedList<Data_Gatcha> drop_gatcha;

    public Game_Manager number_enemy;

    public Image message_drop_gatche_to_hide, power_april, power_june;

    public TextMeshProUGUI message_drop_gatcha;

    public string name_gatcha;

    public int gatcha_price;

    public Data_Gatcha name_charac_drop_now;

    public void Up_oods_gatcha()
    {
        Debug.Log(number_enemy.enemy_dead % 10);
        if (number_enemy.enemy_dead % 10 == 0)
        {
            drop_gatcha.SetWeightAtIndex(1, drop_gatcha.GetWeightAtIndex(1) + 1);
            name_gatcha = "April";
            StartCoroutine(Message_gatcha());
        }

        if (number_enemy.enemy_dead % 100 == 0)
        {
            drop_gatcha.SetWeightAtIndex(0, drop_gatcha.GetWeightAtIndex(0) + 1);
            name_gatcha = "June";
            StartCoroutine(Message_gatcha());
        }
    }

    public IEnumerator Message_gatcha()
    {
        message_drop_gatche_to_hide.gameObject.SetActive(true);
        message_drop_gatcha.text = "Chance Drop "+ name_gatcha + " increase by 1";

        yield return new WaitForSeconds(2);
        message_drop_gatche_to_hide.gameObject.SetActive(false);

        Debug.Log("ici");
    }

    public void On_Buy_Gatcha()
    {
        if (Game_Manager.instance.money_gatcha >= gatcha_price)
        {
            Game_Manager.instance.Take_money_gatcha(gatcha_price);
            name_charac_drop_now = drop_gatcha.GetRandomElement();
            Show_Gatcha_Charac();           
        }
    }

    public void Show_Gatcha_Charac()
    {
        if (name_charac_drop_now == drop_gatcha[1])
        {
            power_april.gameObject.SetActive(true);
        }

        if (name_charac_drop_now == drop_gatcha[2])
        {
            power_june.gameObject.SetActive(true);
        }
    }

}
