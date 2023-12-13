using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gatcha_Manager : MonoBehaviour
{
    public WeightedList<Data_Gatcha> drop_gatcha;

    // Start is called before the first frame update
    public void Debloquage_Liste()
    {
        drop_gatcha.GetRandomElement();
    }

}
