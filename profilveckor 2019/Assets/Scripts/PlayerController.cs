using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public bool defenseBuffActive;
    public bool invincibleBuffActive;
    public bool speedBuffActive;
    public bool healthBuffActive;

    [SerializeField]
    private float defenseTimer;
    [SerializeField]
    private float invincibilityTimer;
    [SerializeField]
    private float speedTimer;
    [SerializeField]
    private float healthTimer;

    float currentDefenseTimer = 0f;
    float currentInvincibilityTimer = 0f;
    float currentSpeedTimer = 0f;
    float currentHealthTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (defenseBuffActive)
        {
            defenseBuffActive = BuffTimer(defenseTimer, ref currentDefenseTimer);

        }
        if (invincibleBuffActive)
        {
            invincibleBuffActive = BuffTimer(invincibilityTimer, ref currentInvincibilityTimer);

        }
        if (speedBuffActive)
        {
            speedBuffActive = BuffTimer(speedTimer, ref currentSpeedTimer);

        }
        if (healthBuffActive)
        {
            healthBuffActive = BuffTimer(healthTimer, ref currentHealthTimer);
        }
    }

    private bool BuffTimer(float timer, ref float currentTimer)
    {
        currentTimer += Time.deltaTime;

        if(currentTimer >= timer)
        {
            currentTimer = 0f;
            return false;
        }

        return true;
    }
}
