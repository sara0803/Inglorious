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
    public Quaternion currentRotation;
    public float speed = 5;
    private Vector3 direction;

    void Start()
    {
        anim = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        
    }

    // Update is called once per frame
  
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
