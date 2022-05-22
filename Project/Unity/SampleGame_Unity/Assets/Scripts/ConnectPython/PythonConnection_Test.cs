using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;

public class PythonConnection_Test : MonoBehaviour
{
    [SerializeField]
    private Text txt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {// 그냥 R 키 누르면 실행
            try
            {
                Process psi = new Process();
                psi.StartInfo.FileName = "C:/Users/YunSeong/AppData/Local/Programs/Python/Python37/python.exe";
                // 파이썬 환경 연결
                psi.StartInfo.Arguments = "C:/Users/YunSeong/Documents/GitHub/Storytelling-Game-Pipeline/Project/Python_NLP/test.py";
                // 실행할 파이썬 파일

                psi.StartInfo.CreateNoWindow = false;
                // Window를 만들지 않음

                psi.StartInfo.UseShellExecute = true;
                // 프로세스를 시작할때 운영체제 셸을 사용할지
                
                //psi.StartInfo.RedirectStandardOutput = true;
                //psi.StartInfo.RedirectStandardError = true;

                psi.Start();

                UnityEngine.Debug.Log("[알림] .py file 실행");
                //Text txt = GetComponentInChildren<Text>();
                txt.text = "Pressed";
            }
            catch (System.Exception e)
            {
                UnityEngine.Debug.LogError("[알림] 에러발생: " + e.Message);
            }
        }
    }
}
