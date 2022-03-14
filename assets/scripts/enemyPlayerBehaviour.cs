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

    //script som g�r att n�r NPCn f�rlorar allt sitt HP s� d�r den
    public void Hit(float damage)
    {
        HitPoints -= damage;
        if (HitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
