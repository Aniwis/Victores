using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MytEst : MonoBehaviour
{
    Victor vector1 = new Victor(2, 4);
    Victor vector2 = new Victor(2, 1);
    Victor vectorPlus;
    Victor vectorSubs;
    Victor vectorMulti;
    Victor vector1Nor;
    Victor vector2Nor;
    float magnitud1, magnitud2;
    void Start()
    {

        vectorPlus = vector1.Suma(vector2);
        vectorSubs = vector1.Resta(vector2);
        vectorMulti = vector2.Multi(3);
        magnitud1 = vector1.Magni();
        magnitud2 = vector2.Magni();
        vector1Nor = vector1.normalice();
        vector2Nor = vector2.normalice();
        Debug.Log("la magnitud del vector 1 es: " + magnitud1);
        Debug.Log("la magnitud del vector 2 es: " + magnitud2);
    }

    private void Update()
    {
        vector1.Draw();
        vector2.Draw();
        vectorPlus.Draw(vector1);
        vectorSubs.Draw(vector2);
        vector1Nor.Draw();
        vector2Nor.Draw();
    }
}