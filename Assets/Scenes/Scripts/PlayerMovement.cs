using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 dir;
    [SerializeField] private Rigidbody2D rb;
    void Start()
    {
        Debug.Log("MEOW!");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMove(InputValue value)
    {
        dir = value.Get<Vector2>();
        rb.velocity = dir * 10;
        Debug.Log(dir);
    }
}
