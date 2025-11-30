using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 4f;
    private Vector2 input;
    private Rigidbody2D rb;



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            input = context.ReadValue<Vector2>();
        }
        else if (context.canceled) 
        {
            input = Vector2.zero;
        }

        if (input.y > 0) Debug.Log("W pressed (moving up)");
        if (input.y < 0) Debug.Log("S pressed (moving down)");
        if (input.x < 0) Debug.Log("A pressed (moving left)");
        if (input.x > 0) Debug.Log("D pressed (moving right)");



    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + input * moveSpeed * Time.fixedDeltaTime);

    }
}
