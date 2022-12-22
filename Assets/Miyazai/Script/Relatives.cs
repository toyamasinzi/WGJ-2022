using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Relatives : MonoBehaviour
{
    [SerializeField, Tooltip("会話のウィンドウのゲームオブジェクトを入れる")]
    GameObject _conversationWindow;
    [SerializeField, Tooltip("DelayTextを入れる")]
    DelayText _delayText;
    [SerializeField,Tooltip("HpBarCtrlを入れる")]
    HpBarCtrl _hpBarCtrl;
    [SerializeField, Tooltip("親戚の会話のテキストを入力")]
    List<string> _inputRelatives;

    [SerializeField, Tooltip("プレイヤーの会話のテキストを入力")]
    List<string> _inputPlayer;

    [SerializeField,Tooltip("親戚の画像")] GameObject _relativesImage;

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
