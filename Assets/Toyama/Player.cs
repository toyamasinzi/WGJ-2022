using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float _speed = 2f;

    private Rigidbody2D _rb;
    private Vector2 _dir = default;

   [SerializeField]
    GameObject _HpBarCtrl;

    HpBarCtrl HBC;
    float horizontalKey;
    float vertical;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        HBC = _HpBarCtrl.GetComponent<HpBarCtrl>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        horizontalKey = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (!HBC.Istalking)
        {



            float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");

            _dir = new Vector2(h, v);
            _rb.velocity = _dir * _speed;


            //else
            //{
            //    rb.velocity = Vector2.zero;
            //}

        }

        void PlayerInBed()
        {
            HBC._hp += HBC._MaxHp / 2;
        }
    }
}
