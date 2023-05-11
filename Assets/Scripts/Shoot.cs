using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletInit;
    public GameObject bulletPrefab;
    public float bulletSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1")) {
            GameObject bulletTemp = Instantiate(bulletPrefab, bulletInit.transform.position, bulletInit.transform.rotation) as GameObject;
            Rigidbody rb = bulletTemp.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * bulletSpeed);
            Destroy(bulletTemp, 5.0f);
        }
    }
}
