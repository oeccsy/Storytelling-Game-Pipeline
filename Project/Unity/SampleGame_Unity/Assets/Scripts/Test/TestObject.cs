using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour
{
    public static GameObject instance;

    private void Awake()
    {
        instance = gameObject;
    }
}
