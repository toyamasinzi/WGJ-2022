using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoney : MonoBehaviour
{
    [SerializeField, Header("���݂̏�������\������e�L�X�g�I�u�W�F�N�g")]
    GameObject TextView;
    void Update()
    {
        TextViewMoney();
    }

    /**  
    <summary>
    �v���C���[�����ݏ������Ă��邨��
    </summary>
    */
    public static int _haveMoney = 0;

    /**  
    <summary>
    Get:�v���C���[�����ݏ������Ă��鑍�z
    Set:�v���C���[�̂��������������Z����
    </summary>
    */
    public int GetSetHaveMoney
    {
        get { return _haveMoney; }

        set { _haveMoney += value; }
    }

    /**  
<summary>
�e�L�X�g�Ɍ��݂̋��z��\������
</summary>
*/
    public void TextViewMoney()
    {
        string _viewmoney = "���݂̏�����" + _haveMoney;
        TextView.GetComponent<Text>().text = _viewmoney;
    }

}