using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    //private PlayerInputActions actions;
    private void Awake()
    {
        m_transform = GetComponent<Transform>();
        m_rigidBody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
 

    void Start()
    {
        
    }
    

    private void FixedUpdate()
    {
        Rotate();
        Move();
    }

    private void Move()
    {
        var value = m_movementInput;
        if (value.y < 0) return;
        m_rigidBody.AddForce(value.y*m_acceleration * -1 * m_transform.up);
    }

    private void Rotate()
    {
        var value = m_movementInput;
        
        Quaternion currentRotation = m_transform.rotation;
        var angle = currentRotation.eulerAngles.z;
        angle -= value.x * m_speedOfRotation * Time.deltaTime;
        m_transform.rotation = Quaternion.Euler(0, 0, angle);
        
    }

    public void OnMoveInputEventRaised(InputAction.CallbackContext _ctx)
    {
        m_movementInput = _ctx.ReadValue<Vector2>();
    }


    private float m_horizontalInput;
    private float m_verticalInput;
    private Transform m_transform;
    public float m_speedOfRotation;
    public float m_acceleration;
    private Rigidbody2D m_rigidBody;
    private Vector2 m_movementInput;
}
