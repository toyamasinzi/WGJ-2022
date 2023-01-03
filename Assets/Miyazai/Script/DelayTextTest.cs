using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;

public class DelayTextTest : MonoBehaviour
{
    //�@���b�Z�[�WUI
    [SerializeField] Text _messageText;
    //�@�\�����郁�b�Z�[�W
    [SerializeField]
    [TextArea(1, 20)]
    private string _allMessage = "";
    [SerializeField, Tooltip("1�������\�����鎞��(�~���b)")]
    int _waitTimeChar;
    string _output;
    bool _isTest=false;
    private void Start()
    {
        _messageText = GetComponentInChildren<Text>();
        _messageText.text = "";
    }
    private async void Update()
    {
        if (_isTest==false)
        {
            _isTest = true;
            await OutputMessage(_allMessage);
        }
    }

    
    //1�������\������
    async Task OutputMessage(string s)
    {
        foreach (char c in s)
        {
            _output += c.ToString();
            _messageText.text = _output;
            await Task.Delay(_waitTimeChar);
        }
        _output += $"\n";
        _messageText.text = _output;
    }
}
