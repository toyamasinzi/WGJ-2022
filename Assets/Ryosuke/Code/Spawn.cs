using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //所定の位置にスポーンさせる

    [SerializeField, Header("オブジェクトのスポーン"), Tooltip("オブジェクトスポーン")]
    private Object[] _spawnObject;

    [SerializeField, Header("スポーンさせる位置"), Tooltip("スポーン位置")]
    private Vector2[] _spawnPosition;

    private void Start()
    {
        SpawnHuman();
    }

    private void SpawnHuman()
    {
        var spawnObjectA = Random.Range(0, _spawnObject.Length);
        Instantiate(_spawnObject[spawnObjectA] , _spawnPosition[0] , Quaternion.identity);

        var spawnObjectB = Random.Range(0 , _spawnObject.Length);
        Instantiate(_spawnObject[spawnObjectB], _spawnPosition[1], Quaternion.identity);

        var spawnObjectC = Random.Range(0 , _spawnObject.Length);
        Instantiate(_spawnObject[spawnObjectC] , _spawnPosition[2] , Quaternion.identity);
    }


}
