using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityBrain : AEntityComponent
{
    public List<AEntityAction> updateActions;

    public Transform movementTarget;

    private void Update()
    {
        if (!IsComponentActive)
        {
            return;
        }

        foreach (var action in updateActions)
        {
            action.Execute(Entity);
        }
    }
}