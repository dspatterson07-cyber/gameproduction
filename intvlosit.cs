using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    //InputAction moveAction;
    private CharacterController player;
    private InputAction moveAction;
    public float Speed;

    void Start()
    {
        player = GetComponent<CharacterController>();
        moveAction = InputSystem.actions.FindAction("move");
    }

    void Update()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        //Vector3 Move = Vector3.zero;
        //Move.x = Input.GetAxis("Horizontal") * Speed;
        //player.Move(Move * Time.deltaTime);
    }
}