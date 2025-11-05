using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityBrain : MonoBehaviour, IEntityComponent
{
    public Entity Entity { get; private set; }
    public bool IsComponentActive { get; private set; }

    public void OnEntityRegistered(Entity entity)
    {
        Entity = entity;

        Debug.Log($"Entity {entity.name} registered with brain {name}");
    }

    public void ResolveDependencies()
    {
        Debug.Log($"Resolving dependencies for brain {name}");
    }

    public void ActivateComponent()
    {
        IsComponentActive = true;
        Debug.Log($"Activated brain {name}");
    }

    public void DeactivateComponent()
    {
        IsComponentActive = false;
        Debug.Log($"Deactivated brain {name}");
    }
}
