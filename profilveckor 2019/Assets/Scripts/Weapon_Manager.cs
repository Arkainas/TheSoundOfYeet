using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Manager : MonoBehaviour
{


    public GameObject activeWeapon;
    weapon wpn;

    // Start is called before the first frame update
    void Start()
    {
        wpn = activeWeapon.GetComponent<weapon>();

        GetComponent<SpriteRenderer>().sprite = wpn.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            GameObject projectile = (GameObject)Instantiate(wpn.projectile, transform.position + wpn.tip, Quaternion.identity);

            if (wpn.projectileMode == weapon.Modes.Straight)
                projectile.GetComponent<Rigidbody2D>().velocity = transform.parent.localScale.x * Vector2.right * wpn.projectileSpeed;
            {

            }

        }

    }
}
