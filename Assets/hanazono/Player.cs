using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _speed = 2f;

    private Rigidbody2D rb;

    [SerializeField]
    GameObject _HpBarCtrl;

    HpBarCtrl HBC;
    float horizontalKey;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        HBC = _HpBarCtrl.GetComponent<HpBarCtrl>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontalKey = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (!HBC.Istalking)
        {
            //右入力で左向きに動く
            if (horizontalKey > 0)
            {
                rb.velocity = new Vector2(_speed, 0);
            }
            //左入力で左向きに動く
            if (horizontalKey < 0)
            {
                rb.velocity = new Vector2(-_speed, 0);
            }
            //上入力で上向きに動く
            if (vertical > 0)
            {
                rb.velocity = new Vector2(0, _speed);
            }
            //下入力で下向きに動く
            if (vertical < 0)
            {
                rb.velocity = new Vector2(0, -_speed);
            }

            if (vertical == 0 && horizontalKey == 0)
            {
                rb.velocity = new Vector2(0, 0);
            }
            //ボタンを話すと止まる
            //else
            //{
            //    rb.velocity = Vector2.zero;
            //}
        }
    }

    void PlayerInBed()
    {
        HBC._hp += HBC._MaxHp / 2;
    }
}
