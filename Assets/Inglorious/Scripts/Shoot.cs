using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletInit;
    public GameObject bulletPrefab;
    public float bulletSpeed;
    public Quaternion currentRotation;
    private AudioSource playerAudio;    
    public AudioClip shoot;
    private bool soundShoot=true;
    
    //private AudioSource ;
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        currentRotation = transform.rotation;
        if (Input.GetButton("Fire1")) {
            GameObject bulletTemp = Instantiate(bulletPrefab, bulletInit.transform.position, bulletInit.transform.rotation) as GameObject;
            Rigidbody rb = bulletTemp.GetComponent<Rigidbody>();
            rb.AddForce(currentRotation * Vector3.forward * bulletSpeed);
            Destroy(bulletTemp, 5.0f);
            //verificar si puede sonar
            if (soundShoot)
            {

                StartCoroutine(horror());
            }
        }
        
    }
    IEnumerator horror() {

        soundShoot = false;
        playerAudio.PlayOneShot(shoot, 1.0f);
        yield return new WaitForSeconds(0.2f);
        soundShoot = true;
    }
}
