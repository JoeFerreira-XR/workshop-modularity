using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MovementComponent))]
public class CameraBehaviour : MonoBehaviour
{
    #region Dependencies
    private MovementComponent movementComponent;
    #endregion
    
    public Transform target;
    public float lerpSpeed = 0.125f;

    private void Awake()
    {
        movementComponent = GetComponent<MovementComponent>();
    }

    void Update()
    {
        movementComponent.LerpToTarget(target, lerpSpeed);
    }
}
