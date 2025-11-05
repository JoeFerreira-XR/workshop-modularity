using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LerpToTargetAction", menuName = "Entity Actions/Movement/Lerp To Target")]
public class LerpToTargetAction : EntityActionBase
{
    public override void Execute(Entity entity)
    {
        var movementComponent = entity.GetEntityComponent<MovementComponent>();
        movementComponent.LerpToTarget(movementComponent.movementTarget, movementComponent.lerpSpeed);
    }
}
