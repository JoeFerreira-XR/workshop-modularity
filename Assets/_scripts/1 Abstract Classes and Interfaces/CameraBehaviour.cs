using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Transform target;
    public float lerpSpeed = 0.125f;

    void Update()
    {
        LerpToTarget();
    }

    void LerpToTarget()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, lerpSpeed);
    }
}
