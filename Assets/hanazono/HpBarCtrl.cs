using UnityEngine;
using UnityEngine.UI; // ���������Y�ꂸ�ɓ����

public class HpBarCtrl : MonoBehaviour
{

   private Slider _slider;
    void Start()
    {
        // �X���C�_�[���擾����
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    float _hp = 0;
    void Update()
    {
        // HP�㏸
        _hp += 0.01f;
        if (_hp > 1)
        {
            // �ő�𒴂�����0�ɖ߂�
            _hp = 0;
        }

        // HP�Q�[�W�ɒl��ݒ�
        _slider.value = _hp;
    }
}
