using UnityEngine;

public abstract class AEntityAction : ScriptableObject, IEntityAction
{
    public abstract void Execute(Entity entity);
}