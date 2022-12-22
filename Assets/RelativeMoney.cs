using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelativeMoney : MonoBehaviour
{
    [Tooltip("�����Ɋ�{�ƂȂ邨�N�ʂ̋��z��ݒ肵�Ă��������B")]
    [SerializeField]
    static int _giftMoney;

    [Tooltip("�����ɂ͏����𖞂��������ɓn�����N�ʂ̋��z��ݒ肵�Ă��������B")]
    [SerializeField]
    static int _upgradeGiftMoney;

    [Tooltip("���̃v���C���[���������Ă��鑼�̐e�ʂ̃I�u�W�F�N�g��ݒ肵�Ă��������B\n�Ȃ����None�̂܂܂ő��v�ł��B")]
    [SerializeField]
    GameObject _HaveInfoRelative;

    /**  
    <summary>
    ���̐e�ʂ����̐e�ʂ������񋟂��ꂽ�����肷��t���O
    </summary>
    */
    public bool _isUpgrade = false;


    [Tooltip("PlayerMoney�i�v���C���[�̂����̊Ǘ�������N���X�j��ǉ����Ă���z��̃v���C���[\nStart�������玩���I�ɐݒ肷��悤�ɂȂ��Ă�̂Ŋ�{�I�ɂ͂�����Ȃ��Ă����v�ł�")]
    [SerializeField]
    GameObject Player;

    /**  
    <summary>
    PlayerMoney�̎Q��
    </summary>
    */
    PlayerMoney _PlayerMoney;

    // Start is called before the first frame update
    void Start()
    {
        //�����I�Ƀv���C���[�I�u�W�F�N�g���擾�ł���悤�ɂ�����
        Player = GameObject.Find("Player");
        _PlayerMoney = Player.GetComponent<PlayerMoney>();
    }

    /**  
    <summary>
    Get:�t���O�������Ă����ꍇ�ɂ����邨���̋��z��upgradeGiftMoney�ɐ؂�ւ���
    Set:�Ȃ�
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
    Get:�t���O�������Ă����ꍇ�ɂ����邨���̋��z��upgradeGiftMoney�ɐ؂�ւ��Ɋ��p
    Set:�I�����ŏ��񋟂�I�񂾏ꍇ�ɑΏۂ̐e�ʂ̂��N�ʋ��z��Up�����邽�߂̃t���O��On�ɂ���
    </summary>
    */
    public bool GetSetTakeInfo
    {
        get { return _isUpgrade; }

        set { _HaveInfoRelative.GetComponent<RelativeMoney>().GetSetTakeInfo = value; }
    }
}
