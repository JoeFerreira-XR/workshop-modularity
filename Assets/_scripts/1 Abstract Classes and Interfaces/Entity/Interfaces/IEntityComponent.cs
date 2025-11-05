using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEntityComponent
{
    Entity Entity { get; }
    bool IsComponentActive { get; }
    void OnEntityRegistered(Entity entity);
    void ResolveDependencies();
    
    void ActivateComponent();
    void DeactivateComponent();
}
