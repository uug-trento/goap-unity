using System.Collections;
using System.Collections.Generic;
using ReGoap.Unity;
using UnityEngine;

public class SimBuildStructureAction : ReGoapAction<GoapKeys, GoapValues>
{
    protected override void Awake()
    {
        base.Awake();
        effects.Set(GoapKeys.BuiltStructure, new GoapValues { Boolean = true });
    }
}
