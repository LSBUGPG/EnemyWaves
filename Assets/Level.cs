using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public List<Wave> waves;

    public IEnumerator PlayLevel()
    {
        foreach (Wave wave in waves)
        {
            Debug.LogFormat("Start {0}", wave.name);

            yield return StartCoroutine(wave.PlayWave());

            // delay before next wave
            yield return new WaitForSeconds(2);
        }
    }
}
