using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
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
}
