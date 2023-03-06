using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBoss : MonoBehaviour
{   
    [SerializeField] collision player;
    [SerializeField] Slider healthBar;
    float currentHealth;
    float maxHealth=20f;

    // Update is called once per frame
    void Update()
    {
        currentHealth = 20 - player.countHurtTime;
        healthBar.value = currentHealth/maxHealth;
    }
}
