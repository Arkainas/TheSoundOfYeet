using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Pickup : MonoBehaviour
{

    public GameObject[] weapons;
    public GameObject weaponsHere;


    // Start is called before the first frame update
    void Start()
    {

        weaponsHere = weapons [Random.Range(0, weapons.Length)];
        GetComponent<SpriteRenderer> ().sprite = weaponsHere.GetComponent<SpriteRenderer> ().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        { }
    }
}
