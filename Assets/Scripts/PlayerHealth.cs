using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100;
    public GameObject healthBar;
    
    void Update()
    {
        healthBar.GetComponent<Slider>().value = health;
    }

    public void TakeDamage(float damageTaken)
    {
        health -= damageTaken;
    }


}
