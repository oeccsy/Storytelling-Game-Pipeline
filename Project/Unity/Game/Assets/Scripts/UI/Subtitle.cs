using TMPro;
using UnityEngine;

namespace UI
{
    public class Subtitle : MonoBehaviour
    {
        private TextMeshProUGUI _textUI;

        private void Awake()
        {
            _textUI = GetComponentInChildren<TextMeshProUGUI>();
        }

        public void SetText(string str)
        {
            _textUI.text = str;
        }

        public void RemoveText()
        {
            _textUI.text = "";
        }
    }
}