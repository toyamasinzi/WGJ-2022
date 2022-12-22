using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class DelayText : MonoBehaviour
{

    [SerializeField,Tooltip("��b�̃e�L�X�g�����")]
    string _input;
    string _output;
    [SerializeField]
    Text _textUI;
    [SerializeField] 
    int _waitTimeChar;

    private async void Start()
    {
        await OutputMessage(_input);
    }
    //1�������\������
    async Task OutputMessage(string s)
    {
        foreach(char c in s)
        {
            _output += c.ToString();
            _textUI.text = _output;
            await Task.Delay(_waitTimeChar);
        }
    }
}
