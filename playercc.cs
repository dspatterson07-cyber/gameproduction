using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    public spawner spawner;
    InputAction attackAction;
    InputAction moveAction;
    InputAction jumpAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attackAction = InputSystem.actions.FindAction("attack");
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("jump");
    }

    // Update is called once per frame
    void Update()
    {
        if(attackAction.IsPressed())
        spawner.isSpawning = true;
    }
}
