using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage_Script : MonoBehaviour
{


    float damage = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.parent.tag != collision.gameObject.tag)
        {
            Health_Script enemyHealth = collision.gameObject.GetComponent<Health_Script>();

            if (enemyHealth)
            {
                enemyHealth.ChangedHealth(-damage);
            }

            Destroy(gameObject);
        }
    }
}
