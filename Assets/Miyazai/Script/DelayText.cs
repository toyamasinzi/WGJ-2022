using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
public class DelayText : MonoBehaviour
{

    [SerializeField,Tooltip("��b�̃e�L�X�g�����")]
    string _output;
    [SerializeField]
    Text _textUI;
    [SerializeField] 
    int _waitTimeChar;
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
