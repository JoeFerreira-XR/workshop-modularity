using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public Transform target;
    public float speed;

    void Update()
    {
        MoveToTarget(target);
    }

    /// <summary>
    /// Move the enemy in a direction
    /// </summary>
    /// <param name="target">target to move to</param>
    void MoveToTarget(Transform target)
    {
        Vector2 targetPos2 = new(target.position.x, target.position.z);
        Vector2 myPos2 = new(transform.position.x, transform.position.z);
        Vector2 direction = (targetPos2 - myPos2).normalized;

        Vector3 direction3 = new(direction.x, 0, direction.y);
        transform.Translate(speed * Time.deltaTime * direction3);
    }
}
