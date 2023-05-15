using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    private bool isOnGround = true;
    private Animator anim;
    public Quaternion currentRotation;
    public float speed;
    private Vector3 direction;

    private int health = 1;



    void Start()
    {
        
        anim = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody>();
       

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            isOnGround = false;
            anim.SetBool("PlayerJump", true);
            anim.SetFloat("Move", 0f);
        }

        if (isOnGround)
        {
            anim.SetBool("PlayerTouchFloor", true);
            anim.SetBool("PlayerJump", false);

        }else{
            anim.SetBool("PlayerTouchFloor", false);
        }

        //Animation Crouching
        if (Input.GetKey(KeyCode.LeftControl))
        {
            anim.SetBool("is_crouching", true);
            gameObject.GetComponent<CapsuleCollider>().height=1.5f;
            gameObject.GetComponent<CapsuleCollider>().center= new Vector3 (-0.02f, 0.68f, -0.02f);

        }
        else{
            anim.SetBool("is_crouching", false);
            gameObject.GetComponent<CapsuleCollider>().height=2.63f;
            gameObject.GetComponent<CapsuleCollider>().center= new Vector3 (-0.02f, 1.23f, -0.02f);


        }
    }


    private void FixedUpdate()
    {
        currentRotation = transform.rotation;
        // Obtener la entrada del teclado y la dirección del jugador
        float input = Input.GetAxisRaw("Horizontal");
        Vector3 direction = new Vector3(input, 0, 0);
        // Si se está moviendo hacia la izquierda, rotar el jugador 180 grados
        if (direction.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 270, 0);
        }
        else if (direction.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        

        Vector3 velocity = playerRb.velocity;
        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A)))
        {
            velocity.x = Input.GetAxis("Horizontal") * speed;
            anim.SetFloat("Move", 1f);
            if (!isOnGround) {
                anim.SetFloat("Move", 0f);
                
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
