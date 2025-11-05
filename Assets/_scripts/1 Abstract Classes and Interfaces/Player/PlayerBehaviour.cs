using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private Entity _playerEntity;
    private MovementComponent _movementComponent;

    void Start()
    {
        if (_playerEntity == null)
        {
            Debug.LogError("Player entity is null");
            enabled = false;
            return;
        }

        _movementComponent = _playerEntity.GetEntityComponent<MovementComponent>();
    }

    void Update()
    {
        _movementComponent.MoveToDirection(GetPlayerInput(), _movementComponent.moveSpeed);
    }

    Vector2 GetPlayerInput()
    {
        return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}