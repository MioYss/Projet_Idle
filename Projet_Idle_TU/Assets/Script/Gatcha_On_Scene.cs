using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gatcha_On_Scene : MonoBehaviour

{
    public Data_Gatcha[] gatcha_to_spawn;

    private Data_Gatcha cur_gatcha;

    public Image sprite_gatcha;

    private void Start()
    {
        Read_Gatcha();

    }

    public void Read_Gatcha()
    {
        cur_gatcha = gatcha_to_spawn[Random.Range(0, gatcha_to_spawn.Length)];
        sprite_gatcha.sprite = cur_gatcha.sprite_gatcha;

    }
}
