using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            Init();
            return _instance;
        }
    }

    public static void Init()
    {
        _instance = GameObject.FindObjectOfType<T>();

        if(_instance == null)
        {
            GameObject obj = new GameObject();
            _instance = obj.AddComponent<T>();
        }
    }
}