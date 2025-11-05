using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    #region Debug stuff
    [Range(-1, 1)]
    public float horizontal;
    [Range(-1, 1)]
    public float vertical;
    [Min(0)]
    public float speed;

    Vector2 MovementDirection
    {
        get => new(horizontal, vertical);
    }
    #endregion

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
