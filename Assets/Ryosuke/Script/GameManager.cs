using System.Collections;
using System.Collections.Generic;
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
            //�����Ɏ��Ԃ̏���
        }

    }


}
