using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaves : MonoBehaviour
{
    public List<Level> levels;

    void Start()
    {
        StartCoroutine(PlayLevels());
    }

    IEnumerator PlayLevels()
    {
        foreach (Level level in levels)
        {
            Debug.LogFormat("Starting {0}", level.name);

            yield return StartCoroutine(level.PlayLevel());
        }
    }
}
