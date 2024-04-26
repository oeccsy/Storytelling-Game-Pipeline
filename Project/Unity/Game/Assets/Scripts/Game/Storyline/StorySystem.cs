using System.Collections;
using UI;
using UnityEngine;

namespace Game.Storyline
{
    public class StorySystem : MonoBehaviour
    {
        [SerializeField]
        private StorySO _curStory;
        [SerializeField]
        private int _storyIndex = 0;
        [SerializeField] [TextArea]
        private string _curContent;
        
        [SerializeField]
        private Subtitle _subtitle;
        
        public delegate void StoryEvent(string text, string status);
        public event StoryEvent OnStoryChanged;

        public IEnumerator ShowSubtitle(int _storyIndex)
        {
            _curContent = _curStory.storyline[_storyIndex];
            
            _subtitle.SetText(_curContent);
            yield return new WaitForSecondsRealtime(3f);
            _subtitle.RemoveText();
        }
    }
}
