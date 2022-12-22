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

    [SerializeField, Tooltip("親戚の会話のテキストを入力")]
    List<string> _inputRelatives;

    [SerializeField, Tooltip("プレイヤーの会話のテキストを入力")]
    List<string> _inputPlayer;

    bool _isConversationTrue = false;
    private void Awake()
    {
        _conversationWindow.SetActive(false);
    }
    void ConversationStart()
    {
        StartCoroutine(DelayText());
    }
    //Test
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)&& _isConversationTrue ==false)
        {
            _isConversationTrue = true;
            _delayText.ConversationDelete();
            ConversationStart();
            _isConversationTrue = false;
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" || Input.GetKeyDown(KeyCode.F))
        {
            _delayText.ConversationDelete();
            ConversationStart();
        }
    }
    IEnumerator DelayText()
    {
        _conversationWindow.SetActive(true);

        yield return new WaitForSeconds(0.5f);
        _delayText.ConversationStart(_inputRelatives);
        Debug.Log("_inputRelatives");

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.F));
        _delayText.ConversationDelete();
        _delayText.ConversationStart(_inputPlayer);
        Debug.Log("_inputPlayer");
    }
}
