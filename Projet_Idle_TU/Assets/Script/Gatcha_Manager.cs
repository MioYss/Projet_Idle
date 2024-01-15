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

    private void Update()
    {
        /*if (number_enemy.enemy_dead >= 10)
        {
            ScriptableObject.June.weight == 1;

            else

            ScriptableObject.June.weight == 0;
        }

        if (number_enemy.enemy_dead >= 50)
        {
            ScriptableObject.April.weight == 10;

            else

            ScriptableObject.April.weight == 0;
        }*/
    }
}
