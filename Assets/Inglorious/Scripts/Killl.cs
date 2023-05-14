using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Killl : MonoBehaviour
{
    public int health = 3;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger detected with: " + other.gameObject.name);
        if (other.gameObject.CompareTag("Bullet"))
        {
            health -= 1;

            Destroy(other.gameObject);

            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

}

