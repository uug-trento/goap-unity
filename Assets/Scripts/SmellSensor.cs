using System.Collections;
using System.Collections.Generic;
using ReGoap.Core;
using ReGoap.Unity;
using UnityEngine;

public class SmellSensor : ReGoapSensor<string, object>
{
    public float SensorRange = 20f;
    [SerializeField] private LayerMask foodLayer;
    private ReGoapState<string, object> worldState;
    private void Start()
    {
        worldState = memory.GetWorldState();
    }

    public override void UpdateSensor()
    {
        Collider2D col = Physics2D.OverlapCircle(transform.position, SensorRange, foodLayer);
        worldState.Set("foodInRange", col != null);
        if (col)
            worldState.Set("food", col.gameObject);
    }

    private void OnDrawGizmos()
    {
        if (worldState != null)
            Gizmos.color = ((bool) worldState.Get("foodInRange")) ? Color.green : Color.white;
        Gizmos.DrawWireSphere(transform.position, SensorRange);
    }
}
