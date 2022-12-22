using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Relatives : MonoBehaviour
{
    [SerializeField, Tooltip("��b�̃E�B���h�E�̃Q�[���I�u�W�F�N�g������")]
    GameObject _conversationWindow;
    [SerializeField, Tooltip("DelayText������")]
    DelayText _delayText;
    [SerializeField,Tooltip("HpBarCtrl������")]
    HpBarCtrl _hpBarCtrl;
    [SerializeField, Tooltip("�e�ʂ̉�b�̃e�L�X�g�����")]
    List<string> _inputRelatives;

    [SerializeField, Tooltip("�v���C���[�̉�b�̃e�L�X�g�����")]
    List<string> _inputPlayer;

    [SerializeField,Tooltip("�e�ʂ̉摜")] GameObject _relativesImage;

    bool _isConversationTrue = false;
    private void Awake()
    {
        _conversationWindow.SetActive(false);
        _relativesImage.SetActive(false);
    }
    void ConversationStart()
    {
        StartCoroutine(DelayText());
    }
    //Test
    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.F)&& _isConversationTrue ==false)
    //    {
    //        _isConversationTrue = true;
    //        _delayText.ConversationDelete();
    //        ConversationStart();
    //        _isConversationTrue = false;
    //    }
    //}
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" || Input.GetKeyDown(KeyCode.F) && _isConversationTrue == false)
        {
            _isConversationTrue = true;
            _delayText.ConversationDelete();
            ConversationStart();
            _isConversationTrue = false;
        }
    }
    IEnumerator DelayText()
    {
        _conversationWindow.SetActive(true);
        _relativesImage.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        _delayText.ConversationStart(_inputRelatives);
        Debug.Log("_inputRelatives");

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.F));
        _delayText.ConversationDelete();
        _delayText.ConversationStart(_inputPlayer);
        Debug.Log("_inputPlayer");
    }
}
