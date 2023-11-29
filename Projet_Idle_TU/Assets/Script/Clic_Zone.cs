using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clic_Zone : MonoBehaviour
{
    public Score_Manger score_ref;

    void Start()
    {
        score_ref = FindObjectOfType<Score_Manger>();

    }

    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        Debug.Log("You have clicked the button!");
        score_ref.score_joueur++;  
    }

}
