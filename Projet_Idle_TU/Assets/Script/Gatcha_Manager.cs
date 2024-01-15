using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gatcha_Manager : MonoBehaviour
{
    public WeightedList<Data_Gatcha> unlock_gatcha;

    public WeightedList<Data_Gatcha> drop_gatcha;

    public Game_Manager number_enemy;

    // Start is called before the first frame update
    public void Unlock_Liste()
    {
        unlock_gatcha.GetRandomElement();
    }

    public void Drop_Liste()
    {

        drop_gatcha.GetRandomElement();
        Debug.Log("ta drop");

    }

    public void up_oods_gatcha()
    {
        if (number_enemy.last_number_enemy % 10 == 0)
        {
            drop_gatcha.SetWeightAtIndex(1, drop_gatcha.GetWeightAtIndex(0) + 1);
            Debug.Log("ta up le drop");
        }
    }

}
