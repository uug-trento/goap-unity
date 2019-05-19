using System.Collections;
using System.Collections.Generic;
using ReGoap.Unity;
using UnityEngine;

public class HappyAnimalGoal : ReGoapGoalAdvanced<string, object>
{
    protected override void Awake()
    {
        base.Awake();
        goal.Set("foodEaten", true);
    }
}
