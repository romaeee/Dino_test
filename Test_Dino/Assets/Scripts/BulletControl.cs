using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public int bulletSpeed = 10;


    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * bulletSpeed;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Environment")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
