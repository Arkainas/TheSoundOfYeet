using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript2 : MonoBehaviour
{
    PlayerController playerController;
    public float panSpeed = 20f;
    [SerializeField]
    float speed = 10f;
    [SerializeField]
    float speedBoostMultiplier;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (playerController.speedBuffActive)
            {
                transform.position += Vector3.left * speed * Time.deltaTime * speedBoostMultiplier;
            }
            else
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (playerController.speedBuffActive)
            {
                transform.position += Vector3.right * speed * Time.deltaTime * speedBoostMultiplier;
            }
            else
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (playerController.speedBuffActive)
            {
                transform.position += Vector3.up * speed * Time.deltaTime * speedBoostMultiplier;
            }
            else
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (playerController.speedBuffActive)
            {
                transform.position += Vector3.down * speed * Time.deltaTime * speedBoostMultiplier;
            }
            else
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
            }
        }
    }
}
