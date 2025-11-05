using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Entity : MonoBehaviour
{
    #region Dependencies
    private Dictionary<Type, IEntityComponent> components;

    private void GetAllComponents()
    {
        components = new Dictionary<Type, IEntityComponent>();
        foreach (IEntityComponent component in GetComponents<IEntityComponent>())
        {
            components.Add(component.GetType(), component);
            component.OnEntityRegistered(this);
        }

        foreach (IEntityComponent component in components.Values)
        {
            component.ResolveDependencies();
        }

        foreach (IEntityComponent component in components.Values)
        {
            component.ActivateComponent();
        }
    }

    public T GetEntityComponent<T>() where T : IEntityComponent
    {
        if (!components.TryGetValue(typeof(T), out IEntityComponent component))
        {
            Debug.LogError($"Component {typeof(T)} not found on entity {name}");
            return default;
        }

        return (T)component;
    }
    #endregion

    void Awake()
    {
        GetAllComponents();
    }
}
