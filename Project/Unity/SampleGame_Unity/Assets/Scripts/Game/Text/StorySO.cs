using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StorySO", menuName = "Scriptable Object/StorySO")]
public class StorySO : ScriptableObject
{
    [SerializeField]
    private static StorySO _instance;
    public static StorySO instance
    {
        get { return _instance; }
    }
    public List<Story> storyList = new List<Story>();
    public Queue<Story> storyQueue = new Queue<Story>();
}