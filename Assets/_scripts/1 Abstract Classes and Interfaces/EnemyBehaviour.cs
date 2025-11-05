using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MovementComponent))]
public class EnemyBehaviour : MonoBehaviour
{
    #region Dependencies
    private MovementComponent movementComponent;
    #endregion
    
    public Transform target;
    public float speed;

    private void Awake()
    {
        movementComponent = GetComponent<MovementComponent>();
    }

    void Update()
    {
        movementComponent.MoveToTarget(target, speed);
    }
}
