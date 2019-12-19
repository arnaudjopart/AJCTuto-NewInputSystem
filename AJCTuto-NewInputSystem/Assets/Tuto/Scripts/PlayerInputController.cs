using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    private void Awake()
    {
        m_transform = GetComponent<Transform>();
        m_rigidBody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }

    private void FixedUpdate()
    {
        m_horizontalInput = Input.GetAxis("Horizontal");
        m_verticalInput = Input.GetAxis("Vertical");
        
        Rotate();
        Move();
    }

    private void Move()
    {
        if (m_verticalInput < 0) return;
        m_rigidBody.AddForce(m_verticalInput*m_acceleration * -1 * m_transform.up);
    }

    private void Rotate()
    {
        Quaternion currentRotation = m_transform.rotation;
        var angle = currentRotation.eulerAngles.z;
        angle -= m_horizontalInput * m_speedOfRotation * Time.deltaTime;
        m_transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    private float m_horizontalInput;
    private float m_verticalInput;
    private Transform m_transform;
    public float m_speedOfRotation;
    public float m_acceleration;
    private Rigidbody2D m_rigidBody;
}
