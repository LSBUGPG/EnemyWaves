using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubWave : MonoBehaviour
{
    public List<Enemy> enemyList;

    public IEnumerator SendWave(Transform spawnPoint, Transform target)
    {
        Coroutine enemyFollow = null;
        foreach (Enemy enemyType in enemyList)
        {
            var enemy = Instantiate(enemyType, spawnPoint);
            enemyFollow = StartCoroutine(enemy.FollowPath(spawnPoint.position, target.position));

            yield return new WaitForSeconds(1);
        }

        // wait for the last enemy to finish its path
        yield return enemyFollow;
    }
}
