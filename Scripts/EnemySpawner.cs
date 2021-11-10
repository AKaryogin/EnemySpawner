using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _template;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private int _count;

    private void Start()
    {
        StartCoroutine(SetSpawn(_count));
    }

    private void Spawn(Vector3 position)
    {
        Instantiate(_template, position, Quaternion.identity);
    }

    private IEnumerator SetSpawn(int countEnemy)
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(2f);
        int indexPoint = 0;

        for(int i = 0; i < countEnemy; i++)
        {
            if(indexPoint >= _spawnPoints.Length)
                indexPoint = 0;

            Spawn(_spawnPoints[indexPoint].position);

            indexPoint++;
            
            yield return waitForSeconds;
        }
    }
}
