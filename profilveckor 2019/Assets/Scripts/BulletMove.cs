using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    float speed = 5;
    Vector2 dir = Vector2.right;
    Rigidbody2D bulletRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bulletRigidbody.velocity = dir * speed;
    }

    public void SetDir (Vector2 bulletDir)
    {
        dir = bulletDir;
    }
}
