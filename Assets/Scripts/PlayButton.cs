using UnityEngine;
using UnityEngine.InputSystem;

public class PlayButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private BoxCollider2D collider;
    [SerializeField]private SpriteRenderer text;

    private void Awake()
    {
        collider = GetComponent<BoxCollider2D>();
    }
    void Start()
    {
        
    }

    public void OnMouseHoverPerformed(InputAction.CallbackContext context)
    {
        text.color = Color.grey;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
