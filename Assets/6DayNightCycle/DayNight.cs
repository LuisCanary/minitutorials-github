using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour {


    //We have two lights one opposite the other and the only rotate
    float cyclemins = 1;//Duration of the full around
    float cyclecalc;
    private void Awake()
    {
         cyclecalc = 0.1f/ cyclemins * -1;
    }

    private void Update()
    {
        transform.Rotate(0, 0, cyclecalc, Space.World);


    }



}
