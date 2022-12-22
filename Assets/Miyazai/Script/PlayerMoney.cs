using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoney : MonoBehaviour
{
    [SerializeField, Header("現在の所持金を表示するテキストオブジェクト")]
    GameObject TextView;
    void Update()
    {
        TextViewMoney();
    }

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

    /**  
<summary>
テキストに現在の金額を表示する
</summary>
*/
    public void TextViewMoney()
    {
        string _viewmoney = "現在の所持金" + _haveMoney;
        TextView.GetComponent<Text>().text = _viewmoney;
    }

}