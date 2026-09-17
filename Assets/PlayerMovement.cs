using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // movement

        Vector2 move = Vector2.zero;

        if (Keyboard.current != null)

        {

            if (Keyboard.current.wKey.isPressed)

                move.y += 1;

            if (Keyboard.current.aKey.isPressed)

                move.x -= 1;

            if (Keyboard.current.sKey.isPressed)

                move.y -= 1;

            if (Keyboard.current.dKey.isPressed)

                move.x += 1;

        } 
        Vector3 dir = move.normalized;

        transform.position += dir * speed * Time.deltaTime; 
    }
}
