using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movespeed;
    public float jumpspeed;
    public bool isgrounded = false; 
    // These variables are to hold the Action references
    InputAction moveAction;
    InputAction jumpAction;


    private void Start()
    {
        // Find the references to the "Move" and "Jump" actions
        rb = GetComponent<Rigidbody2D>();
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("jump");
    }

    void Update()
    {
        //float movespeed = 6f;
        // Read the "Move" action value, which is a 2D vector
        Vector2 moveValue = moveAction.ReadValue<Vector2>();

        rb.linearVelocityX = moveValue.x * movespeed;


        //rb.linearVelocity = new Vector2(moveValue.x * movespeed, moveValue.y);
        //Vector2 moveValue = new Vector2(0.1f, 0); 
        // your movement code here
        //Vector3 moveValue3D = new Vector3(moveValue.x, moveValue.y, 0) * 0.1f;
        //transform.Translate(moveValue3D);
        if (jumpAction.WasPressedThisFrame() && isgrounded)
        {
            rb.linearVelocityY = jumpspeed;
            isgrounded = false;
        }

    }
        private void OnCollisionEnter2D(Collision2D collision)
        {
        isgrounded = true;
        }
        

        
        //transform.Translate(new Vector3(moveValue.x, moveValue.y, 0));
    
}
