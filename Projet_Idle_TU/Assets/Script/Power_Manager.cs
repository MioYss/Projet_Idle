using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power_Manager : MonoBehaviour
{
    public EnnemyOnScene enemy;

    public void Power_Explosion()
    {
        //enemy = FindObjectOfType<EnnemyOnScene>();
        enemy.OneShot();

    }
}
