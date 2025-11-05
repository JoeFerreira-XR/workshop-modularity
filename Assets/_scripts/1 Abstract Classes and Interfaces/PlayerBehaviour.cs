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
        Move(MovementDirection, speed);
    }

    /// <summary>
    /// Move the player in a direction
    /// </summary>
    /// <param name="direction">x = horizontal, y = vertical</param>
    /// <param name="speed">speed of the player</param>
    void Move(Vector2 direction, float speed)
    {
        Vector3 direction3 = new(direction.x, 0, direction.y);
        transform.Translate(speed * Time.deltaTime * direction3);
    }
}
