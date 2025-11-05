using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainComponent : EntityComponentBase
{
    public List<EntityActionBase> updateActions;

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