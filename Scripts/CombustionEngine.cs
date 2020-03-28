using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombustionEngine : IEngine
{
    public void StartEngine()
    {
        KeyInIgnition();
        Debug.Log("Engine started");
    }

    private void KeyInIgnition()
    {
        Debug.Log("The pistons are ready to fire!");
    }
}
