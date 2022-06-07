using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerBehaviorHandler : MonoBehaviour
{
    private Dictionary<string, IPlayerBehavior> behaviorsMap;

    public Player player;

    private void Start()
    {
        this.InitBehaviors();
        player.BehaviorCurrent = behaviorsMap["Idle"];
    }

    private void InitBehaviors()
    {
        this.behaviorsMap = new Dictionary<String, IPlayerBehavior>();
        this.behaviorsMap["Active"] = new PlayerBehaviorActive();
        this.behaviorsMap["Aggressive"] = new PlayerBehaviorAggressive();
        this.behaviorsMap["Idle"] = new PlayerBehaviorIdle();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.player.BehaviorCurrent = behaviorsMap["Aggressive"];
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            this.player.BehaviorCurrent = behaviorsMap["Idle"];
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            this.player.BehaviorCurrent = behaviorsMap["Active"];
        }
    }
}
