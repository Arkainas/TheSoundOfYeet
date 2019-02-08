using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public bool defenseBuffActive;
    public bool invincibleBuffActive;
    public bool speedBuffActive;
    public bool healthBuffActive;
    bool healthboosted;

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

    float originalHealth;
    float boostedHealth;

    Health_Script healthScript;

    // Start is called before the first frame update
    void Start()
    {
        healthScript = GetComponent<Health_Script>();
        originalHealth = healthScript.health;
    }

    // Update is called once per frame
    void Update()
    {
        if (!healthboosted && healthBuffActive)
        {
            healthboosted = true;
            healthScript.health = originalHealth * 1.25f;
        }

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
            if (currentHealthTimer + 0.02f >= healthTimer)
            {
                healthScript.health -= (originalHealth * 1.25f) - originalHealth;
                healthboosted = false;
            }
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
