using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {  
        StartCoroutine(GameSetting());
    }

    private IEnumerator GameSetting()
    {
        //TimeDelay
        yield return new WaitForSeconds(5f);

        //Story가 바뀔때 이벤트 발생 -> CreateData
        StoryManager.Instance.OnStoryShowed += new StoryManager.StoryEvent(DataCreator.CreatePredictData); 
        StoryManager.Instance.OnStoryChanged += new StoryManager.StoryEvent(DataCreator.CreateTraningData);

        //스토리 진행 시작
        StartCoroutine(StoryManager.Instance.StoryRelay(3f, 2f));
    }
}
