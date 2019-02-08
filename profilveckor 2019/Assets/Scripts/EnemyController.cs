using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    enum States {Idle, Follow, Attack, Return};

    States enemyState = States.Idle;
    GameObject player;
    MovementScript2 move;
    Weapon_Manager fire;
    Vector2 returnPosition;
    float followRange = 10;
    float attackRange = 5;
    float returnPointRadius = 0.5f;
    float attackSpeed = 0.5f;
    float attackTimer = 0;
         
    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        returnPosition = transform.position;
        move = GetComponent<MovementScript2>();
        fire = GetComponent<Weapon_Manager>();
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 targetPos = returnPosition;
        float distanceToTarget = 0;    
        
        if(player)
        {
            targetPos = player.transform.position;
            distanceToTarget = Vector2.Distance(transform.position, targetPos);

        }

        if (player && distanceToTarget < attackRange)
        {
            enemyState = States.Attack;
        }

        else if (player && distanceToTarget < followRange)
        {
            enemyState = States.Follow;
        }

        else if(enemyState != States.Idle)
        {
            enemyState = States.Return;
            targetPos = returnPosition;
            distanceToTarget = Vector2.Distance(transform.position, returnPosition);
        }

        Vector2 targetDir = targetPos - transform.position;
        
        if (attackTimer > 0)
        {
            attackTimer -= Time.deltaTime;
        }

        switch (enemyState)
        {
            case States.Follow:
            //Här behövs hjälp med att röra sig i både x och y led


            case States.Attack:
                if (attackTimer <= 0)
                {
                    fire.Attack(targetDir.normalized);
                    attackTimer = attackSpeed;
                }
                break;
            case States.Return:
                if(distanceToTarget < returnPointRadius)
                {
                    enemyState = States.Idle;
                }
                else
                {
                    move.Walk
                }
              
        }
    }
}
