using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gatcha_Manager : MonoBehaviour
{
    public WeightedList<Data_Gatcha> unlock_gatcha;

    public WeightedList<Data_Gatcha> drop_gatcha;

    // Start is called before the first frame update
    public void Unlock_Liste()
    {
        unlock_gatcha.GetRandomElement();
    }

    public void Drop_Liste()
    {

        drop_gatcha.GetRandomElement();

    }

}
