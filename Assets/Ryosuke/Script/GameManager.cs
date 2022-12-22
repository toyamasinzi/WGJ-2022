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
    //�n�܂�����t�F�C�h
    //�I�������t�F�C�h
    //�t�F�C�h���ē��t�̃e�L�X�g�\��


    [SerializeField, Header("���̃V�[���̖��O"), Tooltip("�V�[����")]
    private string _sceneName = "";

    [SerializeField, Header("Day"), Tooltip("StringDay")]
    public Text _dayString;

    [SerializeField,Header("N���ڕ\��"),Tooltip("�o�ߓ���")]
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
