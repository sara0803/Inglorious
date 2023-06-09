using System;
using System.Collections;
using System.Collections.Generic;
using Inglorious.Scripts;
using UnityEngine;
using UnityEngine.AI;


public class Killl : MonoBehaviour
{
    public int health = 100;
    public Animator anim;
    private bool ifdie=true;
    public AudioClip monsterSound;
    private AudioSource playerAudio;

    private void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger detected with: " + other.gameObject.name);
        if (other.gameObject.CompareTag("Bullet"))
        {
            health -= 1;
            
            Destroy(other.gameObject);

            if (health <= 0)
            {
                
                if (ifdie)
                {
                    
                    Destroy(this.gameObject.GetComponent<IEnemyIA>());
                    Destroy(this.gameObject.GetComponent<NavMeshAgent>());
                    Destroy(this.gameObject.GetComponent<CapsuleCollider>());
                    StartCoroutine(TimeWait());
                    
                }
                
            }
        }

       /* if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject.GetComponent<PlayerController>());
            Destroy(other.gameObject.GetComponent<Shoot>());
            
        }   */
    }

    IEnumerator TimeWait() { 

        
        ifdie = false;
        anim.SetTrigger("Die");
        playerAudio.PlayOneShot(monsterSound, 1.0f);
        yield return new WaitForSeconds(3.0f);
        
        Destroy(gameObject);
        ifdie = true;
        
    }
    
}

