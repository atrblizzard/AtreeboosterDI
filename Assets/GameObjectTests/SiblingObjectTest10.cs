﻿using System.Collections;
using UnityEngine;

public class SiblingObjectTest10 : MonoBehaviourExtended, ITest
{
    [Sibling(999, Optional = true)]
    private GameObject go;

    private void Start()
    {
        if (!Test())
        {
            Debug.LogError("Test failed: " + this);
        }
    }

    public bool Test()
    {
        StartCoroutine(DelayedTest());
        if (go == null)
        {
            return true;
        }
        return false;
    }

    private IEnumerator DelayedTest()
    {
        yield return new WaitForSeconds(1);
        if (go == null && GameObject.Find("Sibling900") == null)
        {
            yield break;
        }
        Debug.LogError("Test failed: " + this);
    }
}