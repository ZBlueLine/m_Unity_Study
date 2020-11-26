using UnityEngine;
using System.Collections.Generic;

[ExecuteInEditMode]
public class TestCancelInvoke : MonoBehaviour
{
    public GameObject projectile;

    void Start()
    {
        // Starting in 2 seconds, a projectile will be launched every 0.3 seconds
        //InvokeRepeating("LaunchProjectile", 2, 0.3F);
    }

    void LaunchProjectile()
    {
        // Create a projectile GameObject and set its velocity to a random direction
        GameObject instance = Instantiate(projectile);
        Rigidbody rigidbody = instance.GetComponent<Rigidbody>();

        rigidbody.velocity = Random.insideUnitSphere * 5;
    }

    void Update()
    {
        // Cancel all Invoke calls
        if (Input.GetButton("Fire1"))
            CancelInvoke("LaunchProjectile");
    }
}