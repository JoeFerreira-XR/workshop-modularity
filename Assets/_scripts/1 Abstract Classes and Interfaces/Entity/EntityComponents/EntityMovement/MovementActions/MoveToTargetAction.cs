using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MoveToTargetAction", menuName = "Entity Actions/Movement/Move To Target")]
public class MoveToTargetAction : EntityActionBase
{
    public override void Execute(Entity entity)
    {
        var movementComponent = entity.GetEntityComponent<MovementComponent>();
        movementComponent.MoveToTarget(movementComponent.movementTarget, movementComponent.moveSpeed);
    }
}