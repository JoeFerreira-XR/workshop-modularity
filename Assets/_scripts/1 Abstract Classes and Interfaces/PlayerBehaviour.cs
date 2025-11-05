using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EC_Movement))]
public class PlayerBehaviour : MonoBehaviour
{
    #region Dependencies
    private EC_Movement movementComponent;
    #endregion

    [SerializeField] private float speed;

    private void Awake()
    {
        movementComponent = GetComponent<EC_Movement>();
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
