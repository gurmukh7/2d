using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    public Transform BulletSpawn;
    public GameObject BulletPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Fire();
        }
    }
    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var Bullet = (GameObject)Instantiate(
            BulletPrefab,
            BulletSpawn.position,
            BulletSpawn.rotation);
        // Add velocity to the Bullet
        Bullet.GetComponent<Rigidbody>().velocity = Bullet.transform.forward * 6;
        // Destroy the Bullet after 2 seconds
        Destroy(Bullet, 5.0f);

    }
}
