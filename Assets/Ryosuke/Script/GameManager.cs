using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //始まったらフェイド
    //終わったらフェイド
    //フェイドして日付のテキスト表示

    [SerializeField, Header("次のシーンの名前"), Tooltip("シーン名")]
    private string _sceneName = "";

    [SerializeField, Header("Day"), Tooltip("StringDay")]
    public Text _dayString;


    private GameObject Text;
    public  GameObject Fade;
    public  Fade fadeScript;

    GameObject _dayEnd;

    private void Start()
    {

        if(Input.GetMouseButtonDown(0))
        {
            fadeScript = GetComponent<Fade>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            //ここに時間の処理
        }

    }


}
