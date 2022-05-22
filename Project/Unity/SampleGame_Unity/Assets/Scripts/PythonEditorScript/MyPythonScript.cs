/*
using Python.Runtime;
using UnityEditor.Scripting.Python;
using UnityEditor;
using UnityEngine;

public class MyPythonScript
{
    [MenuItem("MyPythonScript/Run")]
    public static void Run()
    {
        PythonRunner.EnsureInitialized();
        using (Py.GIL()) {
            try {
                dynamic sys = PythonEngine.ImportModule("sys");
                UnityEngine.Debug.Log($"python version: {sys.version}");
            } catch(PythonException e) {
                UnityEngine.Debug.LogException(e);
            }
        }
    }
}
*/