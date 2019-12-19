using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingSystem : MonoBehaviour
{
    public GameObject m_projectilePrefab;

    private float m_lastShootTime;
    public float m_fireRate;
    private Transform m_transform;

    // Start is called before the first frame update
    void Start()
    {
        m_transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (Time.time > m_lastShootTime + m_fireRate)
        {
            m_lastShootTime = Time.time;
            var projectileInstance =
                Instantiate(m_projectilePrefab, m_transform.position, m_transform.rotation*Quaternion.Euler(0,0,180)) as GameObject;
        }
    }
}
