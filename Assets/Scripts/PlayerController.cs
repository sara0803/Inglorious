using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody playerRb;
    public float jumpForce = 10f;
    public float gravityModifier;
    private bool isOnGround = true;
    private Animator anim;
    public float speed = 5;
    private Vector3 direction;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    public AudioClip walkSound;
    public AudioClip shootSound;
    private AudioSource playerAudio;
    void Start()
    {
        anim = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
  
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            isOnGround = false;
            anim.SetFloat("Move", 0f);


        }

        Vector3 velocity = playerRb.velocity;
        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A)))
        {
            velocity.x = Input.GetAxis("Horizontal") * speed;
            anim.SetFloat("Move", 1f);
            if (!isOnGround) {
                anim.SetFloat("Move", 0f);
                playerAudio.PlayOneShot(walkSound, 1.0f);
            }
        }
        else {
            velocity.x = 0f;
            anim.SetFloat("Move", 0f);
        }
        playerRb.velocity = velocity;
    }
    private void OnCollisionEnter(Collision collision)
    {
       
            isOnGround = true;
    }
}
