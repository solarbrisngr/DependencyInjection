using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnoopyDriver : IDriver
{
    private Bike m_Bike;

    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("Snoopy is fighting the Red Baron, with you as a copilot.");
    }
}
