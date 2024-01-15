using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gatcha_Manager : MonoBehaviour
{
    //public WeightedList<Data_Gatcha> unlock_gatcha;

    public WeightedList<Data_Gatcha> drop_gatcha;

    public Game_Manager number_enemy;

   /* public void Unlock_Liste()
    {
        unlock_gatcha.GetRandomElement();
    }*/

    public void Drop_Liste()
    {

        drop_gatcha.GetRandomElement();

    }

    public void Up_oods_gatcha() // a faire prok quand mon ennemy meurt
    {
        Debug.Log(number_enemy.enemy_dead % 10);
        if (number_enemy.enemy_dead % 10 == 0)
        {
            drop_gatcha.SetWeightAtIndex(1, drop_gatcha.GetWeightAtIndex(1) + 1);

        }

        if (number_enemy.enemy_dead % 100 == 0)
        {
            drop_gatcha.SetWeightAtIndex(0, drop_gatcha.GetWeightAtIndex(0) + 1);
        }
    }

}
