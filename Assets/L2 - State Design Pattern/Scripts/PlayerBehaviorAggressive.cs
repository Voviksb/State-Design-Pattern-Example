using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviorAggressive : IPlayerBehavior
{
    public void Enter()
    {
        Debug.Log("Enter Aggressive behavior");
    }

    public void Exit()
    {
        Debug.Log("Exit Aggressive behavior");
    }

    public void Update()
    {
        Debug.Log("Update Aggressive behavior");
    }
}
