using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Manger : MonoBehaviour

{
    public TextMeshProUGUI texte_score;
    public int score_joueur;
    public Ennemy_On_Scene enemy;



    private void Update()
    {
        texte_score.text = "" + score_joueur;
    }
}
