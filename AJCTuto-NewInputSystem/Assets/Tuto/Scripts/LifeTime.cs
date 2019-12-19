using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTime : MonoBehaviour
{
    public float m_lifeTime=10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_lifeSpent += Time.deltaTime;
        if(m_lifeSpent>m_lifeTime) Destroy(gameObject);
    }

    private float m_lifeSpent;
}
