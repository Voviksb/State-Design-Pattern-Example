using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviorActive : IPlayerBehavior
{
    public void Enter()
    {
        Debug.Log("Enter Active behavior");
    }

    public void Exit()
    {
        Debug.Log("Exit Active behavior");
    }

    public void Update()
    {
        Debug.Log("Update Active behavior");
    }
}
