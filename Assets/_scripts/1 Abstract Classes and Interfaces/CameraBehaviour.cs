using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EC_Movement))]
public class CameraBehaviour : MonoBehaviour
{
    #region Dependencies
    private EC_Movement movementComponent;
    #endregion
    
    public Transform target;
    public float lerpSpeed = 0.125f;

    private void Awake()
    {
        movementComponent = GetComponent<EC_Movement>();
    }

    void Update()
    {
        movementComponent.LerpToTarget(target, lerpSpeed);
    }
}
