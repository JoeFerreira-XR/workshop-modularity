using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MoveToDirectionAction", menuName = "Entity Actions/Movement/Move To Direction")]
public class MoveToDirectionAction : EntityActionBase
{
    public override void Execute(Entity entity)
    {
        var movementComponent = entity.GetEntityComponent<MovementComponent>();
        movementComponent.MoveToDirection(movementComponent.movementDirection, movementComponent.moveSpeed);
    }
}