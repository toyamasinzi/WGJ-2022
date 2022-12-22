using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    /**  
    <summary>
    プレイヤーが現在所持しているお金
    </summary>
    */
    public static int _haveMoney = 0;

    /**  
    <summary>
    Get:プレイヤーが現在所持している総額
    Set:プレイヤーのお金を引数分加算する
    </summary>
    */
    public int GetSetHaveMoney
    {
        get { return _haveMoney; }

        set { _haveMoney += value; }
    }
}
