using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Entity))]
public class EntityBrain : MonoBehaviour
{
    #region Dependencies
    [SerializeField] private Entity entity;
    #endregion

    void Awake()
    {
        entity = GetComponent<Entity>();
    }
}
