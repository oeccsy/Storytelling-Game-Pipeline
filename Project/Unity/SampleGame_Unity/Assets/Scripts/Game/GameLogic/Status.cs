using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    public enum StatusType
    {
        None = 0,
        Happy,
        Sad
    }

    private static StatusType _statusType = StatusType.Sad;

    public static StatusType statusType
    {
        get { return _statusType; }
        set
        {
            _statusType = value;
            status = statusType.ToString();
        }
    }
    public static string status = "Sad";

    public int feel_int = 0;

    
}
