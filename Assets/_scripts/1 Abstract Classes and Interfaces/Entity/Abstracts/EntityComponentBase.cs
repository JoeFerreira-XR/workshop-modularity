using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EntityComponentBase : MonoBehaviour, IEntityComponent
{
    public Entity Entity { get; private set; }

    public bool IsComponentActive { get; private set; }

    public void OnEntityRegistered(Entity entity)
    {
        Entity = entity;
    }

    public virtual void ResolveDependencies()
    {
        
    }

    public virtual void ActivateComponent()
    {
        gameObject.SetActive(true);
        IsComponentActive = true;
    }

    public virtual void DeactivateComponent()
    {
        gameObject.SetActive(false);
        IsComponentActive = false;        
    }
}
