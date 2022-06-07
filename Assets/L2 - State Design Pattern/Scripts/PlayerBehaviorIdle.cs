using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviorIdle : IPlayerBehavior
{
    public void Enter()
    {
        Debug.Log("Enter Idle behavior");
    }

    public void Exit()
    {
        Debug.Log("Exit Idle behavior");
    }

    public void Update()
    {
        Debug.Log("Update Idle behavior");
    }
}
