using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade_Clic : MonoBehaviour
{
    public Clic_Zone autoclicker;
    void Start()
    {
        autoclicker = FindObjectOfType<Clic_Zone>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
