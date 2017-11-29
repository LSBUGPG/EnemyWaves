using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPoint;
    public Transform target;

    public List<SubWave> subWaves;
    public float delay = 1.0f;

    public IEnumerator PlayWaves()
    {
        foreach (SubWave subWave in subWaves)
        {
            Debug.LogFormat("{0} starts {1}", name, subWave.name);

            yield return subWave.SendWave(spawnPoint, target);

            yield return new WaitForSeconds(delay);
        }
    }
}
