using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    public Image healthBar;
    public float health;
    public float startHealth;

    public void onTakeDamage(int damage)
    {
        //n�r "ontagedamage" triggas kommer Health vara lika med "health - damage" och sedan kommer detta health at vissas
        //p� healtbaren. 

        health = health - damage;
        healthBar.fillAmount = health / startHealth;
    }
}
