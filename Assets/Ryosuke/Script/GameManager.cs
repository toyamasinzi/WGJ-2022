using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using UnityEditor.SceneManagement;
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

    [SerializeField,Header("N日目表示"),Tooltip("経過日数")]
    public GameObject Text;
    public GameObject Fade;
    public Fade fadeScript;

    GameObject _dayEnd;

    private void Start()
    {

        fadeScript = GetComponent<Fade>();
    }

    private void OnTriggerEnter(Collider other)
    {
        fadeScript.isFadeOut = true;
        Text.SetActive(true);
    }


}
