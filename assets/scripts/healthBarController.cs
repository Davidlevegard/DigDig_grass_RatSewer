using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBarController : MonoBehaviour
{
    public Image healthBar;
    public float health;
    public float startHealth;

    public void onTakeDamage(int damage)
    {
        //när "ontagedamage" triggas kommer Health vara lika med "health - damage" och sedan kommer detta health at vissas
        //på healtbaren. 

        health = health - damage;
        healthBar.fillAmount = health / startHealth;
    }
    public void onTakeHealing(int healing)
    {
        health = health + healing;
        healthBar.fillAmount = health * startHealth;
    }
}