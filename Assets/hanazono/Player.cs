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
        float x = Input.GetAxisRaw("Horizontal"); //â°ï˚å¸ÇÃì¸óÕÇÃílÇéÊìæ
        float y = Input.GetAxisRaw("Vertical");  //ècï˚å¸ÇÃì¸óÕÇÃílÇéÊìæ


        //âE
        if (x > 0)
        {
            transform.position += transform.right * Time.deltaTime * _speed;
        }
        //ç∂
        if (x < 0)
        {
            transform.position -= transform.right * Time.deltaTime * _speed;
        }
        //è„
        if (y > 0)
        {
            transform.position += transform.up * Time.deltaTime * _speed;
        }
        //â∫
        if (y < 0)
        {
            transform.position -= transform.up * Time.deltaTime * _speed;
        }
    }
}
