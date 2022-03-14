using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{

    //here are all the variables for the bullet 
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    //public AudioSource ShootingSound;
    // Update is called once per frame

    private void Start()
    {
        //ShootingSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        //here is the code for when you press button 1 you fire the bullet
        if (Input.GetButtonDown("Fire1"))
        {
            //ShootingSound.Play();

            shoot();
        }
        void shoot()
        {
            //this code  spawns in the bullet and selcets the force of the bullet. 
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        }
    }
}

