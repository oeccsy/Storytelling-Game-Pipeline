using System.Collections;
using System.Collections.Generic;
using UnityEditor.Scripting.Python;
using UnityEditor;
using UnityEngine;

public class MoveObject
{
    [MenuItem("Python Scripts/Move Object")]
    static void Move()
    {
        PythonRunner.RunString(@"
                import UnityEngine
                all_objects = UnityEngine.Object.FindObjectsOfType(UnityEngine.GameObject)
                    for go in all_objects:
                        if go.name[-1] != '_':
                            go.name = go.name + '_'
                ");
                //안됨
    }
}
