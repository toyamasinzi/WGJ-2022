using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;

public class DelayText1 : MonoBehaviour
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
    //�e�X�g�p
    bool _isTest=false;
    private void Start()
    {
        _messageText.text = "";
    }
    //�e�X�g�p
    //private async void Update()
    //{
    //    if (_isTest==false)
    //    {
    //        _isTest = true;
    //        await OutputMessage(_allMessage);
    //        Debug.Log("neko");
    //    }
    //}

    
    //1�������\������
    async Task OutputMessage(string s)
    {
        foreach (char c in s)
        {
            //Debug.Log(c);
            _output += c.ToString();
            _messageText.text = _output;
            Debug.Log(_output);
            await Task.Delay(_waitTimeChar);
        }
    }
    public void ConversationDelete()
    {
        _output = "";
        _messageText.text = _output;
    }
}
