using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField]
    float speed = 50f;
    Vector2 direction;
    Rigidbody2D bulletRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bulletRigidbody.velocity = direction * speed;
    }

    internal void SetDir(Vector2 dir)
    {
        direction = dir;
    }
}
