using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MovementComponent))]
public class PlayerBehaviour : MonoBehaviour
{
    #region Dependencies
    private MovementComponent movementComponent;
    #endregion

    [SerializeField] private float speed;

    private void Awake()
    {
        movementComponent = GetComponent<MovementComponent>();
    }
    
    Vector2 MovementDirection
    {
        get => new(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    void Update()
    {
        movementComponent.MoveToDirection(MovementDirection, speed);
    }
}
