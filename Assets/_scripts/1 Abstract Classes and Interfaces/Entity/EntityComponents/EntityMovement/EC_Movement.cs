using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EC_Movement : AEntityComponent
{
    #region Movement Types
    /// <summary>
    /// Move the player in a direction
    /// </summary>
    /// <param name="direction">x = horizontal, y = vertical</param>
    /// <param name="speed">speed of the player</param>
    public void MoveToDirection(Vector2 direction, float speed)
    {
        Vector3 direction3 = new(direction.x, 0, direction.y);
        transform.Translate(speed * Time.deltaTime * direction3);
    }

    /// <summary>
    /// Move the player to a target
    /// </summary>
    /// <param name="target">target to move to</param>
    /// <param name="speed">speed of the player</param>
    public void MoveToTarget(Transform target, float speed)
    {
        Vector2 direction = GetTargetDirection(target);
        MoveToDirection(direction, speed);
    }

    /// <summary>
    /// Lerp the player to a target
    /// </summary>
    /// <param name="target">target to move to</param>
    /// <param name="lerpSpeed">lerp speed of the player</param>
    public void LerpToTarget(Transform target, float lerpSpeed)
    {
        transform.position = Vector3.Lerp(transform.position, target.position, lerpSpeed);
    }
    #endregion

    #region Auxiliars
    /// <summary>
    /// Get the direction to a target
    /// </summary>
    /// <param name="target">target to move to</param>
    /// <returns>direction to the target</returns>
    public Vector2 GetTargetDirection(Transform target)
    {
        Vector2 targetPos2 = new(target.position.x, target.position.z);
        Vector2 myPos2 = new(transform.position.x, transform.position.z);
        Vector2 direction = (targetPos2 - myPos2).normalized;
        return direction;
    }
    #endregion
}