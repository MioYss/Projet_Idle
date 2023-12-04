using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power_Manager : MonoBehaviour
{
    public Enemy mob_hp;

    public void Power_Explosion()
    {
        mob_hp = FindObjectOfType<Enemy>();
        mob_hp.cur_HP -= 15;

        if (mob_hp.cur_HP <= 0)
        {
            mob_hp.Caught();
        }

    }
}
