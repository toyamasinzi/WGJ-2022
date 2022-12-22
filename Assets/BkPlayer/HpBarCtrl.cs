using UnityEngine;
using UnityEngine.UI; // ���������Y�ꂸ�ɓ����

public class HpBarCtrl : MonoBehaviour
{
    [SerializeField, Header("Player��hp�̍ő�l")]
    public float _MaxHp = 0;
    [SerializeField, Header("�v���C���[��HP�@�r���������ōő�l�ɍ��킹��̂ŕK�v�Ȃ�")]
    public float _hp = 0;
    private Slider _slider;

    public bool Istalking = false;

    void Start()
    {
        // �X���C�_�[��擾����
        _hp = _MaxHp;
    }
    void Update()
    {        // HP�㏸
        _hp += 0.01f;
        if (_hp > 1)

            if (Istalking == false)
            {

                _hp -= Time.deltaTime;
            }



        if (_hp < 0)
        {
            // �ő�𒴂�����0�ɖ߂�
            _hp = 0;
        }

        // HP�Q�[�W�ɒl��ݒ�
        _slider.value = _hp;
    }
    public void TalkEvent(float value)
    {
        _hp -= value;
    }
}