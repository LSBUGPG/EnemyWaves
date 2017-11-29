using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public IEnumerator FollowPath(Vector3 start, Vector3 end)
    {
        float journeyTime = 5.0f;
        float position = 0.0f;
        while (position < 1.0f)
        {
            position += Time.deltaTime / journeyTime;
            transform.position = Vector3.Lerp(start, end, position);
            yield return null;

        }
        Destroy(gameObject);
    }
}
