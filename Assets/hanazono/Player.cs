using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _speed = 1;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); //横方向の入力の値を取得
        float y = Input.GetAxisRaw("Vertical");  //縦方向の入力の値を取得


        //右
        if (x > 0)
        {
            transform.position += transform.right * Time.deltaTime * _speed;
        }
        //左
        if (x < 0)
        {
            transform.position -= transform.right * Time.deltaTime * _speed;
        }
        //上
        if (y > 0)
        {
            transform.position += transform.up * Time.deltaTime * _speed;
        }
        //下
        if (y < 0)
        {
            transform.position -= transform.up * Time.deltaTime * _speed;
        }
    }
}
