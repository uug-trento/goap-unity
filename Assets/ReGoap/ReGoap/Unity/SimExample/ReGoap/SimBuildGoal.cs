using System.Collections;
using System.Collections.Generic;
using ReGoap.Unity;
using UnityEngine;

public class SimBuildGoal : ReGoapGoal<GoapKeys, GoapValues>
{
    protected override void Awake()
    {
        base.Awake();
        goal.Set(GoapKeys.BuiltStructure, new GoapValues { Boolean = true });
    }
}
