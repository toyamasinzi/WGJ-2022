using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
public class DelayText : MonoBehaviour
{

    [SerializeField,Tooltip("��b�̃e�L�X�g�����")]
    List<string> _input;
    string _output;
    [SerializeField]
    Text _textUI;
    [SerializeField] 
    int _waitTimeChar;
    [SerializeField]
    int _waitTimeLine;

    private async void Start()
    {
        foreach(var input in _input)
        {
            await OutputMessage(input);
            await Task.Delay(_waitTimeLine);
        }
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
