using UnityEngine;
using UnityEngine.UI; // ���������Y�ꂸ�ɓ����

public class HpBarCtrl : MonoBehaviour
{
    [SerializeField,Header("�v���C���[��HP")]
    public float _hp = 0;
    private Slider _slider;
    private int _empty = 0;
    private float Nothing = 0;
   
    public bool Istalking = false;
  
    void Start()
    {
        Nothing = 20;
        // �X���C�_�[���擾����
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }


    void Update()
    {

        if(Istalking == false)
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
