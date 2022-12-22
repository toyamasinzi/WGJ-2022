using UnityEngine;
using UnityEngine.UI; // ←※これを忘れずに入れる

public class HpBarCtrl : MonoBehaviour
{
    [SerializeField, Header("Playerのhpの最大値")]
    public float _MaxHp = 0;
    [SerializeField,Header("プレイヤーのHP　Ｓｔａｒｔで最大値に合わせるので必要なし")]
    public float _hp = 0;
    private Slider _slider;
   
   
    public bool Istalking = false;
  
    void Start()
    {
        _hp = _MaxHp;
        // スライダーを取得する
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
            // 最大を超えたら0に戻す
            _hp = 0;
        }

        // HPゲージに値を設定
        _slider.value = _hp;
    }
    public void TalkEvent(float value)
    {     
            _hp -= value;
    }
}
