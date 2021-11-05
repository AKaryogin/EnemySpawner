using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _template;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private int _countEnemy;

    private void Start()
    {
        StartCoroutine(SetSpawn(_countEnemy));
    }

    public void Spawn(Vector3 position)
    {
        Instantiate(_template, position, Quaternion.identity);
    }

    private IEnumerator SetSpawn(int countEnemy)
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(2f);

        for(int i = 0, k = 0; i < countEnemy; i++, k++)
        {
            if(k >= _spawnPoints.Length)
                k = 0;

            Spawn(_spawnPoints[k].position);
            
            yield return waitForSeconds;
        }
    }
}
