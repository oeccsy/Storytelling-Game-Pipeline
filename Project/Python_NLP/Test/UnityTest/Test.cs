/*
using Python.Runtime;
using UnityEditor.Scripting.Python;

public class Test
{
    public static void Run()
    {
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