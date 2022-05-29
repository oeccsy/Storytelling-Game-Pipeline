using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataCreator : Singleton<DataCreator>
{
    public static void CreateTraningData(string curText, string curStatus)
    {
        string targetText = curText + "," + curStatus;
        using (StreamWriter file = new StreamWriter(@"./Data/data_traning.txt", true)) //Assets/Scripts/Python/Test
        {
            file.WriteLine(targetText);
        }

        Debug.Log("Create Train Data Complete");
    }

    public static void CreatePredictData(string curText, string curStatus)
    {
        string targetText = curText;
        using (StreamWriter file = new StreamWriter(@"./Data/data_predict.txt", false)) //Assets/Scripts/Python/Test
        {
            file.WriteLine(targetText);
        }

        Debug.Log("Create Predict Data Complete");
    }
    
}
