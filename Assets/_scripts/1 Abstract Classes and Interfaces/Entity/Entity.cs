using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MovementComponent))]
public class Entity : MonoBehaviour
{
    #region Dependencies
    [SerializeField] private MovementComponent movementComponent;
    #endregion

    #region Public Properties
    public MovementComponent MovementComponent => movementComponent;
    #endregion

    void Awake()
    {
        movementComponent = GetComponent<MovementComponent>();
    }
}
