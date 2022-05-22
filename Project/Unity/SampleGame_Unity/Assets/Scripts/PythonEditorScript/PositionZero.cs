using UnityEditor;
using UnityEditor.Scripting.Python;

public class MenuItem_PositionZero_Class
{
   [MenuItem("Python Scripts/PositionZero")]
   public static void PositionZero()
   {
       PythonRunner.RunFile("Assets/Scripts/PythonScripts/PositionZero.py");

       //string test = PythonRunner.RunFile("Assets/Scripts/PythonScripts/PositionZero.py");
    }
}
