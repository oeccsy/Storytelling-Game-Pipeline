using UnityEditor;
using UnityEditor.Scripting.Python;

public class Training
{
   [MenuItem("Python Scripts/Training")]
   public static void Train()
   {
       PythonRunner.RunFile("Assets/Scripts/Python/Test/test.txt");
    }
}
