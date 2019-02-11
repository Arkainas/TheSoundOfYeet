using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage_Script : MonoBehaviour
{

    [SerializeField]
    float damage = 50;

    PlayerController damageReduction;
    

    // Start is called before the first frame update
    void Start()
    {
        damageReduction.GetComponent<PlayerController>();
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

            PlayerController enemyDamageReduction = collision.gameObject.GetComponent<PlayerController>();

            if (enemyHealth && enemyDamageReduction.invincibleBuffActive)
            {
                enemyHealth.ChangedHealth(-damage * 0);
            }
            else if (enemyHealth && enemyDamageReduction.defenseBuffActive)
            {
                enemyHealth.ChangedHealth(-damage * damageReduction.boostedDefenseMultiplier);
            }
            else if(enemyHealth)
            {
                enemyHealth.ChangedHealth(-damage);
            }

            Destroy(gameObject);
        }
    }
}
