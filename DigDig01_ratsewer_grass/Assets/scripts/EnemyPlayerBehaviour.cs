using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPlayerBehaviour : MonoBehaviour
{
    //variablar
    public float HitPoints;
    public float MaxHitpoints = 5;

    void Start()
    {

    }

    //script som gör att när NPCn förlorar allt sitt HP så dör den
    public void Hit(float damage)
    {
        HitPoints -= damage;
        if (HitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
