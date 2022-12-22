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
        float x = Input.GetAxisRaw("Horizontal"); //�������̓��͂̒l��擾
        float y = Input.GetAxisRaw("Vertical");  //�c�����̓��͂̒l��擾

        horizontalKey = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        //�E
        if (x > 0)
        {
            transform.position += transform.right * Time.deltaTime * _speed;
        }
        //��
        if (x < 0)
        {
            transform.position -= transform.right * Time.deltaTime * _speed;
        }
        //��
        if (y > 0)
        if (!HBC.Istalking)
        {
            transform.position += transform.up * Time.deltaTime * _speed;
        }
        //��
        if (y < 0)
        {
            transform.position -= transform.up * Time.deltaTime * _speed;
            //�E���͂ō������ɓ���
            if (horizontalKey > 0)
            {
                rb.velocity = new Vector2(_speed, 0);
            }
            //�����͂ō������ɓ���
            if (horizontalKey < 0)
            {
                rb.velocity = new Vector2(-_speed, 0);
            }
            //����͂ŏ�����ɓ���
            if (vertical > 0)
            {
                rb.velocity = new Vector2(0, _speed);
            }
            //�����͂ŉ������ɓ���
            if (vertical < 0)
            {
                rb.velocity = new Vector2(0, -_speed);
            }

            if (vertical == 0 && horizontalKey == 0)
            {
                rb.velocity = new Vector2(0, 0);
            }
            //�{�^����b���Ǝ~�܂�
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