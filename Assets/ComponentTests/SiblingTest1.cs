﻿using UnityEngine;

public class SiblingTest1 : MonoBehaviourExtended, ITest
{
    [SiblingComponent]
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
            if (name.Equals("Inventory holder A"))
            {
                return true;
            }
        }
        return false;
    }
}