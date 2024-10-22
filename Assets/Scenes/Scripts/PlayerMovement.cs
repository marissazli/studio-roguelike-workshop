using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 5.0f;
    private Vector2 lastMovementDir = Vector2.zero;
    void Start()
    {
        Debug.Log("MEOW!");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = lastMovementDir * speed;
    }

    private void OnMove(InputValue value)
    {
        lastMovementDir = value.Get<Vector2>();
        Debug.Log(lastMovementDir);
    }
}
