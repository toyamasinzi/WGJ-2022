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
        float x = Input.GetAxisRaw("Horizontal"); //�������̓��͂̒l���擾
        float y = Input.GetAxisRaw("Vertical");  //�c�����̓��͂̒l���擾


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
        {
            transform.position += transform.up * Time.deltaTime * _speed;
        }
        //��
        if (y < 0)
        {
            transform.position -= transform.up * Time.deltaTime * _speed;
        }
    }
}
