using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChickenPlay : MonoBehaviour
{
    [SerializeField] float velocity = 20f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            rb.velocity = Vector2.up * velocity;
        }
    }
}
