using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{

    public Rigidbody bullet;
    private float bulletSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Fire()
    {
        Rigidbody newBullet = Instantiate(bullet, transform.position, transform.rotation);
        newBullet.velocity = transform.forward * bulletSpeed;
        Destroy(newBullet.gameObject, 3);
    }
}
