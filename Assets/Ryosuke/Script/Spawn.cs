using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //����̈ʒu�ɃX�|�[��������

    [SerializeField, Header("�I�u�W�F�N�g�̃X�|�[��"), Tooltip("�I�u�W�F�N�g�X�|�[��")]
    private Object[] _spawnObject;

    [SerializeField, Header("�X�|�[��������ʒu"), Tooltip("�X�|�[���ʒu")]
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
