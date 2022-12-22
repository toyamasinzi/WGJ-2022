using UnityEngine;
using UnityEngine.UI;

public class HpBarCtrl : MonoBehaviour
{
    [SerializeField, Header("Player??hp????l")]
    public float _MaxHp = 0;
    [SerializeField, Header("?v???C???[??HP?@?r????????????l?????????K?v???")]
    public float _hp = 0;
    private Slider _slider;

    public bool Istalking = false;

    void Start()
    {
        _hp = _MaxHp;
    }
    void Update()
    {
        _hp += 0.01f;
        if (_hp > 1)

            if (Istalking == false)
            {

                _hp -= Time.deltaTime;
            }



        if (_hp < 0)
        {
            _hp = 0;
        }
        _slider.value = _hp;
    }
    public void TalkEvent(float value)
    {
        _hp -= value;
    }
}