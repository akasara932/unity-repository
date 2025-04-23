using UnityEngine;
using UnityEngine.InputSystem;

public class charactermove : MonoBehaviour
{
    [SerializeField]
    private PlayerInput playerInput;
    
    private float moveSpeed = 5.0f;
    
    private InputAction moveAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var direction = new Vector3(horizontal, vertical,0);
        direction=direction.normalized;
        transform.position += direction * moveSpeed * Time.deltaTime;
        
    }
}
