using System.Collections.Generic;
using UnityEngine;

namespace Game.Storyline
{
    [CreateAssetMenu(fileName = "StorySO", menuName = "Scriptable Object/StorySO")]
    public class StorySO : ScriptableObject
    {
        [TextArea]
        public List<string> storyline = new List<string>();
    }
}