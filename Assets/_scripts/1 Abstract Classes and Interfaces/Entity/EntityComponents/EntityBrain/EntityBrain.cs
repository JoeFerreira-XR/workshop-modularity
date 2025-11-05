using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityBrain : AEntityComponent
{
    public List<AEntityAction> updateActions;

    private void Update()
    {
        foreach (var action in updateActions)
        {
            action.Execute(Entity);
        }
    }
}