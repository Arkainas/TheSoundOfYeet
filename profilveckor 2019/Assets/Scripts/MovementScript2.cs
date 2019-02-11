using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript2 : MonoBehaviour
{
    Rigidbody playerRigidbody;

    PlayerController playerController;
    [SerializeField]
    float speed = 10f;
    [SerializeField]
    float speedBoostMultiplier;
    float originSpeed;

    [SerializeField]
    string playerHorizontal = "Horizontal_P1";
    [SerializeField]
    string playerVertical = "Vertical_P1";
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerController = GetComponent<PlayerController>();
        originSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.speedBuffActive)
        {
            speed = playerController.boostedSpeedMultiplier;
        }
        else
        {
            speed = originSpeed;
        }

        if (Input.GetAxisRaw(playerHorizontal) != 0 || Input.GetAxisRaw(playerVertical) != 0)
        {
            Vector2 inputDir = new Vector2(Input.GetAxisRaw(playerHorizontal), Input.GetAxisRaw(playerVertical)).normalized;
            Debug.Log("Dir " + inputDir);
            playerRigidbody.velocity = (inputDir * speed);
            Debug.Log("Velocity: " + playerRigidbody.velocity);
        }
        else
        {
            playerRigidbody.velocity = new Vector2(0, 0);
        }

    }
}
