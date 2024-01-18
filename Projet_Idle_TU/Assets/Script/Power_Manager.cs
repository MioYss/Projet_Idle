using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power_Manager : MonoBehaviour
{
    public Ennemy_On_Scene enemy;

    public void Power_Explosion()
    {
        //enemy = FindObjectOfType<EnnemyOnScene>();
        enemy.OneShot();

    }

    public void Power_Fireball()
    {
        enemy.Fireball();

    }

    public void Power_Firewall()
    {
        enemy.Firewall();

    }
}
