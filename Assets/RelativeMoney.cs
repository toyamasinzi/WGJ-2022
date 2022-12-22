using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelativeMoney : MonoBehaviour
{
    [Tooltip("ここに基本となるお年玉の金額を設定してください。")]
    [SerializeField]
    static int _giftMoney;

    [Tooltip("ここには条件を満たした時に渡すお年玉の金額を設定してください。")]
    [SerializeField]
    static int _upgradeGiftMoney;

    [Tooltip("このプレイヤーが所持している他の親戚のオブジェクトを設定してください。\nなければNoneのままで大丈夫です。")]
    [SerializeField]
    GameObject _HaveInfoRelative;

    /**  
    <summary>
    この親戚が他の親戚から情報を提供されたか判定するフラグ
    </summary>
    */
    public bool _isUpgrade = false;


    [Tooltip("PlayerMoney（プレイヤーのお金の管理をするクラス）を追加している想定のプレイヤー\nStart処理から自動的に設定するようになってるので基本的にはいじらなくても大丈夫です")]
    [SerializeField]
    GameObject Player;

    /**  
    <summary>
    PlayerMoneyの参照
    </summary>
    */
    PlayerMoney _PlayerMoney;

    // Start is called before the first frame update
    void Start()
    {
        //自動的にプレイヤーオブジェクトを取得できるようにしたい
        Player = GameObject.Find("Player");
        _PlayerMoney = Player.GetComponent<PlayerMoney>();
    }

    /**  
    <summary>
    Get:フラグが立っていた場合にあげるお金の金額をupgradeGiftMoneyに切り替える
    Set:なし
    </summary>
    */
    public int GetSetGiveMoney
    {
        get
        {
            if (GetSetTakeInfo)
            {
                return _upgradeGiftMoney;
            }
            else
            {
                return _giftMoney;
            }
        }
    }
    /**  
    <summary>
    Get:フラグが立っていた場合にあげるお金の金額をupgradeGiftMoneyに切り替えに活用
    Set:選択肢で情報提供を選んだ場合に対象の親戚のお年玉金額をUpさせるためのフラグをOnにする
    </summary>
    */
    public bool GetSetTakeInfo
    {
        get { return _isUpgrade; }

        set { _HaveInfoRelative.GetComponent<RelativeMoney>().GetSetTakeInfo = value; }
    }
}
