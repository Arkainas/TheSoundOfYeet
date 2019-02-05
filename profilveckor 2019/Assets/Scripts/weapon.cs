using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{

    public enum Modes
    { melle, Straight, Follow, Throw}

    public Sprite sprite;
    public GameObject projectile;
    public float projectileSpeed;
    public float coolDown;
   
    public Modes projectileMode;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    
  
}
