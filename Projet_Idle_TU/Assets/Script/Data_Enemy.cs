using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New_enemy", menuName = "enemy", order = 0)]
public class Data_Enemy : ScriptableObject
{
    public int max_HP;

    public int money_drop;

    public Sprite sprite_enemy;

}
