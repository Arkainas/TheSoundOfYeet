using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Manager : MonoBehaviour
{


    public GameObject activeWeapon;
    weapon wpn;
    bool canShoot = true;


    // Start is called before the first frame update
    void Start()
    {

        wpn = activeWeapon.GetComponent<weapon>();

        GetComponent<SpriteRenderer>().sprite = wpn.sprite;

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Mouse0) && canShoot)
        {

            canShoot = false;
            StartCoroutine("CoolDown");

            GameObject projectile = (GameObject)Instantiate(wpn.projectile, transform.position, Quaternion.identity);

            Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - wpn.transform.position;

            projectile.GetComponent<BulletMove>().SetDir(dir);

            if (wpn.projectileMode == weapon.Modes.Straight)   
            {
                projectile.GetComponent<Rigidbody2D>().velocity = transform.parent.localScale.x * dir * wpn.projectileSpeed;
            }
            else if (wpn.projectileMode == weapon.Modes.Throw)
            {

                projectile.GetComponent<Rigidbody2D>().isKinematic = false;

                projectile.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.parent.localScale.x, 1) * wpn.projectileSpeed;
            }

        }

    }

    IEnumerator CoolDown()
    {

        yield return new WaitForSeconds(wpn.coolDown);
        canShoot = true;

    }

    public void UpdateWeapon(GameObject newWeapon)
    {

        activeWeapon = newWeapon;
        wpn = activeWeapon.GetComponent<weapon>();
        GetComponent<SpriteRenderer>().sprite = wpn.sprite;

    }
}
