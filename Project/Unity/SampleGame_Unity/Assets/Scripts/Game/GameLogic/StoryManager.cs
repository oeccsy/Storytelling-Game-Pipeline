using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryManager : Singleton<StoryManager>
{
    [Header("Interactable Obj")]
    [SerializeField]
    private StorySO storySO;

    [SerializeField]
    private Text storyText;

    [Header("Manage")]
    [SerializeField]
    private string _curText;

    public string curText 
    {
        get { return _curText; }
        set
        {
            _curText = value;
            storyText.text = "\"" + _curText + "\"";
        }
    }
    [SerializeField]
    private int _storyIndex = 0;
    
    public int storyIndex
    {
        get { return _storyIndex; }
        set
        {
            _storyIndex = value;
            curText = storySO.storyList[_storyIndex].text;
        }
    }

    [SerializeField]
    private Coroutine coroutine;

    public delegate void StoryEvent(string text, string status);
    public event StoryEvent OnStoryChanged;
    public event StoryEvent OnStoryShowed;

#region Basic Manage
    public void SetStory(Story story)
    {
        curText = story.text;
    }

    public void SetStory(int index)
    {
        storyIndex = index;
    }

    public void ShowStory()
    {
        storyText.gameObject.SetActive(true);
    }

    public void HideStory()
    {
        storyText.gameObject.SetActive(false);
    }

    public void ResetStoryIndex()
    {
        storyIndex = 0;
    }

    
#endregion

#region Manage
    public void ShowNextStory()
    {
        storyIndex = storyIndex + 1;
        Debug.Log("test");
        ShowStory();
    }

    private IEnumerator Timer(float seconds)
    {
        ShowStory();
        yield return new WaitForSeconds(seconds);
        HideStory();
    }

    public void ShowForTime(float time)
    {
        if(coroutine != null)
        {
            StopCoroutine(coroutine);
        }
        coroutine = StartCoroutine(Timer(time));
    }

    public IEnumerator StoryRelay(float showTime, float hideTime)
    {
        storyIndex = 0;

        while(true)
        {
            OnStoryShowed(curText, Status.status); //predict할 data 생성
            yield return Timer(showTime);
            yield return new WaitForSeconds(hideTime);

            if(storyIndex + 1 < storySO.storyList.Count)
            {
                OnStoryChanged(curText, Status.status); //traning할 data 생성
                storyIndex = storyIndex + 1;
            }
            else
            {
                break;
            }
        }
    }
#endregion
}
