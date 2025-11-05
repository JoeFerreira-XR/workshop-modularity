using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EC_Movement))]
public class EnemyBehaviour : MonoBehaviour
{
    #region Dependencies
    private EC_Movement movementComponent;
    #endregion
    
    public Transform target;
    public float speed;

    private void Awake()
    {
        movementComponent = GetComponent<EC_Movement>();
    }

    void Update()
    {
        movementComponent.MoveToTarget(target, speed);
    }
}
