using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Manager : MonoBehaviour
{
    public GameObject[] enemy_prefab;
    public Enemy cur_enemy;
    public Transform canvas;

    public static Enemy_Manager instance;

    private void Awake()
    {
        instance = this;
    }

    public void Spawn_Enemy()
    {
        GameObject enemy_spawn = enemy_prefab[Random.Range(0,enemy_prefab.Length)];
        GameObject obj = Instantiate(enemy_spawn, canvas);

        cur_enemy = obj.GetComponent<Enemy>();
    }

    public void Replace_Enemy(GameObject enemy)
    {
        Destroy(enemy);
        Spawn_Enemy();
    }
}
