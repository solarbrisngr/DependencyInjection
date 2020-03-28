using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DapperDanDriver : IDriver
{
    private Bike m_Bike;

    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("A Dapper Dan will be your chauffeur today");
    }
}
