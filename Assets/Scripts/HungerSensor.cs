using System;
using System.Collections;
using System.Collections.Generic;
using ReGoap.Unity;
using UnityEngine;

public class HungerSensor : ReGoapSensor<string, object>
{
    public float Calories = 1000;

    public override void UpdateSensor()
    {
        var worldState = memory.GetWorldState();
        worldState.Set("hungry", (Calories < 400));
        
    }

    private void FixedUpdate()
    {
        Calories -= 9 * Time.fixedDeltaTime;
    }
}