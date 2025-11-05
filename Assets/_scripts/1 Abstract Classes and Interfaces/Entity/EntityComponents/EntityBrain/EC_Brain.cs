using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EC_Brain : AEntityComponent
{
    public List<AEntityAction> updateActions;

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