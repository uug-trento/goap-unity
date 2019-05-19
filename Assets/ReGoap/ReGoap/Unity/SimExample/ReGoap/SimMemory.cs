using System.Collections;
using System.Collections.Generic;
using ReGoap.Unity;
using UnityEngine;

public class SimMemory : ReGoapMemory<GoapKeys, GoapValues>
{
}

public enum GoapKeys
{
    BuiltStructure
}

public struct GoapValues
{
    public bool Boolean;
}