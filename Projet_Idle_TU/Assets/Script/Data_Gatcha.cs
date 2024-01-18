using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New_perso", menuName = "perso_gatcha", order = 0)]
public class Data_Gatcha : ScriptableObject
{
    internal static object drop_gatcha;
    public Sprite sprite_gatcha;

    public int rarity;

    public string perso_name, power;

}
