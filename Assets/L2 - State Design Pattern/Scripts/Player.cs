using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    
    private IPlayerBehavior behaviorCurrent;

    public IPlayerBehavior BehaviorCurrent
    {
        set
        {
            if(behaviorCurrent != null)
            {
                behaviorCurrent.Exit();
            }
            behaviorCurrent = value;
            behaviorCurrent.Enter();
        }
    }

    private void Update()
    {
        if(this.behaviorCurrent != null)
        {
            this.behaviorCurrent.Update();
        }
    }
}
