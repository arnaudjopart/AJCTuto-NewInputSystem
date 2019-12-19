using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float m_moveSpeed;

    private Transform m_transform;

    // Start is called before the first frame update
    void Start()
    {
        m_transform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        m_transform.position += Time.deltaTime * m_moveSpeed*m_transform.up;
    }
}
