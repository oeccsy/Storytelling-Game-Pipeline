using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using System.IO;

public class PythonConnection_Test : MonoBehaviour
{
    [SerializeField]
    public static Text processText;

   

    [SerializeField]
    public static Text resultText;

    [SerializeField]
    public static Text storyInfoText;

    [SerializeField]
    public static Text resultInfoText;



    void Start()
    {
        processText = GetComponent<Text>();
        resultText = transform.parent.GetChild(1).GetComponent<Text>();
        storyInfoText = transform.parent.GetChild(2).GetComponent<Text>();
        resultInfoText = transform.parent.GetChild(3).GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            ExcuteTraningAndReturn();
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            //상세한 결과를 포함한 출력
            ExcuteTraningAndPrint();
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            int result_int = 2;
            Status.StatusType result_status = (Status.StatusType)result_int;
            UnityEngine.Debug.Log(result_status);
            string result_string = result_status.ToString();
            resultText.text = "이벤트 타입 : " + result_string;
            //ExcuteTest3();
        }
    }


    public static void ExcuteTraningAndReturn()
    {
        try
            {
                Process psi = new Process();
                psi.StartInfo.FileName = "./samplegame_model/samplegame_model.exe";
                // 파이썬 환경 연결
                psi.StartInfo.Arguments = "";
                // 실행할 파이썬 파일

                psi.StartInfo.CreateNoWindow = true;
                // Window를 만들지 않음
                psi.StartInfo.UseShellExecute = false;
                // 프로세스를 시작할때 운영체제 셸을 사용할지 (true일 경우 결과값 받아올 수 없음)

                psi.StartInfo.RedirectStandardOutput = true;
                psi.StartInfo.RedirectStandardError = true;

                storyInfoText.text = "대상 text : " + StoryManager.Instance.curText;

                psi.Start();

                using(StreamReader reader = psi.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    UnityEngine.Debug.Log(result);

                    int result_int = int.Parse(result);
                    Status.StatusType result_status = (Status.StatusType)result_int;
                    string result_string = result_status.ToString();
                    resultText.text = "이벤트 타입 : " + result_string;
                }

                UnityEngine.Debug.Log("ExcuteTraning");
                processText.text = "ExcuteTraning";
            }
            catch (System.Exception e)
            {
                UnityEngine.Debug.LogError("ExcuteTraning Error : " + e.Message);
                processText.text = "ExcuteTraning Error : " + e.Message;
            }
    }

    public static void ExcuteTraningAndPrint()
    {
        try
            {
                Process psi = new Process();
                psi.StartInfo.FileName = "./samplegame_model/samplegame_model.exe";
                // 파이썬 환경 연결
                psi.StartInfo.Arguments = "";
                // 실행할 파이썬 파일

                psi.StartInfo.CreateNoWindow = true;
                // Window를 만들지 않음
                psi.StartInfo.UseShellExecute = false;
                // 프로세스를 시작할때 운영체제 셸을 사용할지 (true일 경우 결과값 받아올 수 없음)

                psi.StartInfo.RedirectStandardOutput = true;
                psi.StartInfo.RedirectStandardError = true;

                psi.Start();

                using(StreamReader reader = psi.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    UnityEngine.Debug.Log(result);
                    resultText.text = result;
                }

                UnityEngine.Debug.Log("ExcuteTraning");
                processText.text = "ExcuteTraning";
            }
            catch (System.Exception e)
            {
                UnityEngine.Debug.LogError("ExcuteTraning Error : " + e.Message);
                processText.text = "ExcuteTraning Error : " + e.Message;
            }
    }

    public static void ExcuteTest2()
    {
        try
            {
                Process psi = new Process();
                psi.StartInfo.FileName = "C:/Users/YunSeong/Documents/GitHub/Storytelling-Game-Pipeline/Project/Python_NLP/Model/dist/model_1.exe";
                // 파이썬 환경 연결
                psi.StartInfo.Arguments = "";
                // 실행할 파이썬 파일

                psi.StartInfo.CreateNoWindow = true;
                // Window를 만들지 않음

                psi.StartInfo.UseShellExecute = false;
                // 프로세스를 시작할때 운영체제 셸을 사용할지

                psi.StartInfo.RedirectStandardOutput = true;
                psi.StartInfo.RedirectStandardError = true;

                psi.Start();

                using(StreamReader reader = psi.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    UnityEngine.Debug.Log(result);
                    resultText.text = result;
                }

                UnityEngine.Debug.Log("ExcuteTest");
                processText.text = "ExcuteTest";
            }
            catch (System.Exception e)
            {
                UnityEngine.Debug.LogError("ExcuteTest Error : " + e.Message);
                processText.text = "ExcuteTest Error : " + e.Message;
            }
    }

    public static void ExcuteTest3()
    {
        try
            {
                Process psi = new Process();
                psi.StartInfo.FileName = "./samplegame_model/samplegame_model.exe";
                // 파이썬 환경 연결
                psi.StartInfo.Arguments = "";
                // 실행할 파이썬 파일

                psi.StartInfo.CreateNoWindow = true;
                // Window를 만들지 않음

                psi.StartInfo.UseShellExecute = false;
                // 프로세스를 시작할때 운영체제 셸을 사용할지

                psi.StartInfo.RedirectStandardOutput = true;
                psi.StartInfo.RedirectStandardError = true;

                psi.Start();

                using(StreamReader reader = psi.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    UnityEngine.Debug.Log(result);
                    resultText.text = result;
                }

                UnityEngine.Debug.Log("ExcuteTest");
                processText.text = "ExcuteTest";
            }
            catch (System.Exception e)
            {
                UnityEngine.Debug.LogError("ExcuteTest Error : " + e.Message);
                processText.text = "ExcuteTest Error : " + e.Message;
            }
    }
}
