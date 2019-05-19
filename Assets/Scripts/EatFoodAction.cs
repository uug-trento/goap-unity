using System;
using System.Collections;
using System.Collections.Generic;
using ReGoap.Core;
using ReGoap.Unity;
using UnityEngine;

public class EatFoodAction : ReGoapAction<string, object>
{
    protected override void Awake()
    {
        base.Awake();
        preconditions.Set("hungry", true);
        preconditions.Set("foodInRange", true);
        effects.Set("foodEaten", true);
    }

    public override void Run(IReGoapAction<string, object> previous, IReGoapAction<string, object> next,
        ReGoapState<string, object> settings, ReGoapState<string, object> goalState,
        Action<IReGoapAction<string, object>> done, Action<IReGoapAction<string, object>> fail)
    {
        base.Run(previous, next, settings, goalState, done, fail);
        StartCoroutine(MoveTowardsCarrot());
    }

    IEnumerator MoveTowardsCarrot()
    {
        GameObject food = (GameObject)agent.GetMemory().GetWorldState().Get("food");
        if (food)
        {
            while (Vector3.Distance(transform.position, food.transform.position) > 0.5f)
            {
                transform.position -= (transform.position - food.transform.position).normalized * 0.1f;
                yield return new WaitForSeconds(0.1f);
            }

            Destroy(food);
        }

        doneCallback(this);
    }
}
