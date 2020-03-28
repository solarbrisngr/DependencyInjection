using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricEngine : IEngine
{
    public void StartEngine()
    {
        BatteriesOn();
        Debug.Log("Engine started");
    }

    private void BatteriesOn()
    {
        Debug.Log("Battery Noises, but no explosions!");
    }
}
