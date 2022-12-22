using UnityEngine;
using UnityEngine.UI; // ←※これを忘れずに入れる

public class HpBarCtrl : MonoBehaviour
{
    [SerializeField,Header("プレイヤーのHP")]
    public float _hp = 0;
    private Slider _slider;
    private int _empty = 0;
    private float Nothing = 0;
   
    public bool Istalking = false;
  
    void Start()
    {
        Nothing = 20;
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
