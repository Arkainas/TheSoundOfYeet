using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField]
    float speed = 1f;
    float dirX = 1;
    Rigidbody2D bulletRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bulletRigidbody.velocity = Vector2.right * dirX * speed;
    }

    internal void SetDir(Vector2 dir)
    {
        throw new NotImplementedException();
    }
}
