using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float torqueForce = 1f;
    InputAction moveAction;
    Rigidbody2D playerRigidBody2D;
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        playerRigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 moveVector;
        moveVector = moveAction.ReadValue<Vector2>();
        if(moveVector.x < 0)
        {
            playerRigidBody2D.AddTorque(torqueForce);
        }
        else if (moveVector.x > 0)
        {
            playerRigidBody2D.AddTorque(-1 * torqueForce);
        }
    }
}
