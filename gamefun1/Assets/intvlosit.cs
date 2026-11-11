using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    float speed = 20.0f;
    //InputAction moveAction;
    private CharacterController player;
    private InputAction moveAction;
    //public float Speed;

    void Start()
    {
        
        player = GetComponent<CharacterController>();
        GetComponent<Rigidbody2D>().linearVelocity = transform.right * speed;
        moveAction = InputSystem.actions.FindAction("move");
    }

    void Update()
    {
        
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        
    }
}