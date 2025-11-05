using UnityEngine;

public abstract class EntityActionBase : ScriptableObject, IEntityAction
{
    public abstract void Execute(Entity entity);
}