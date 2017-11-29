using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public List<Spawner> spawners;

    public IEnumerator PlayWave()
    {
        List<Coroutine> routines = new List<Coroutine>();

        foreach (Spawner spawner in spawners)
        {
            routines.Add(StartCoroutine(spawner.PlayWaves()));
        }

        // wait for all spawners to finish
        foreach (Coroutine coroutine in routines)
        {
            yield return coroutine;
        }
    }
}
