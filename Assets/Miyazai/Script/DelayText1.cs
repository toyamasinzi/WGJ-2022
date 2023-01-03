using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;

public class DelayText1 : MonoBehaviour
{
    //　メッセージUI
    [SerializeField] Text _messageText;
    //　表示するメッセージ
    [SerializeField]
    [TextArea(1, 20)]
    private string _allMessage = "";
    [SerializeField, Tooltip("1文字ずつ表示する時間(ミリ秒)")]
    int _waitTimeChar;
    string _output;
    //テスト用
    bool _isTest=false;
    private void Start()
    {
        _messageText.text = "";
    }
    //テスト用
    //private async void Update()
    //{
    //    if (_isTest==false)
    //    {
    //        _isTest = true;
    //        await OutputMessage(_allMessage);
    //        Debug.Log("neko");
    //    }
    //}

    
    //1文字ずつ表示する
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
