﻿using UnityEngine;

public class OwnTest1 : MonoBehaviourExtended, ITest
{
    [OwnComponent]
    private Inventory inventory;

    private void Start()
    {
        if (!Test())
        {
            Debug.LogError("Test failed: " + this);
        }
    }

    public bool Test()
    {
        if (inventory != null)
        {
            var name = inventory.gameObject.name;
            Debug.Log("Found component Inventory in " + name + " for " + this);
            if (name.Equals("Inventory holder B"))
            {
                return true;
            }
        }
        return false;
    }
}