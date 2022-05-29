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

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            MenuItem_SetTexttest_Class.SetTexttest();
        }
    }
}
