using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //�n�܂�����t�F�C�h
    //�I�������t�F�C�h
    //�t�F�C�h���ē��t�̃e�L�X�g�\��

<<<<<<< .merge_file_a23656

=======
>>>>>>> .merge_file_a17280
    [SerializeField, Header("���̃V�[���̖��O"), Tooltip("�V�[����")]
    private string _sceneName = "";

    [SerializeField, Header("Day"), Tooltip("StringDay")]
    public Text _dayString;

<<<<<<< .merge_file_a23656
    private GameObject Text;

    public GameObject Fade;
    public Fade fadeScript;

=======

    private GameObject Text;
    public  GameObject Fade;
    
>>>>>>> .merge_file_a17280

    GameObject _dayEnd;

    private void Start()
    {
<<<<<<< .merge_file_a23656
        

        

        if(Input.GetMouseButtonDown(0))
        {
            fadeScript = GetComponent<Fade>();
        }
        
=======

        if(Input.GetMouseButtonDown(0))
        {
    
        }
>>>>>>> .merge_file_a17280
    }

    private void OnTriggerEnter(Collider other)
    {
<<<<<<< .merge_file_a23656
        fadeScript.isFadeOut = true;
        Text.SetActive(true);
=======
        if(other.gameObject.CompareTag("Player"))
        {
            //�����Ɏ��Ԃ̏���
        }

>>>>>>> .merge_file_a17280
    }


}
