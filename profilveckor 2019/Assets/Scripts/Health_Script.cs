using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Script : MonoBehaviour
{
    [SerializeField]
    float health = 100;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangedHealth(float healthModifier)
    {
        health += healthModifier;
        if (health <= 1)
        {
            Destroy(gameObject);
        }
    }
}
