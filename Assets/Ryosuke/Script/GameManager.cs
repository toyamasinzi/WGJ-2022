using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //始まったらフェイド
    //終わったらフェイド
    //フェイドして日付のテキスト表示

<<<<<<< .merge_file_a23656

=======
>>>>>>> .merge_file_a17280
    [SerializeField, Header("次のシーンの名前"), Tooltip("シーン名")]
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
            //ここに時間の処理
        }

>>>>>>> .merge_file_a17280
    }


}
