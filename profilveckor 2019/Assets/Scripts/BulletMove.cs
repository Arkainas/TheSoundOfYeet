using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    GameObject player;
    float speed = 10f;
    Vector2 direction;
    Rigidbody bulletRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        direction = - player.transform.GetChild(0).right;
    }

    // Update is called once per frame
    void Update()
    {
        bulletRigidbody.velocity = direction * speed;
    }

    

    internal void SetDir(Vector2 dir)
    {
        //direction = dir.normalized;
    }
}
