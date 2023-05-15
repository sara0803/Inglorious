using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerDeath : MonoBehaviour
{
    public event EventHandler _playerDeath;
    public PlayerSpawner playerSpawner;


    // Start is called before the first frame update
    void Start()
    {

        playerSpawner = FindObjectOfType<PlayerSpawner>();

    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.y < -27f)
        {
            Dead();
        }


        // Verifica si el objeto del jugador ha sido destruido

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Monster"))
        {

            Dead();


        }

    }
    private void Dead() 
    {
        gameObject.SetActive(false);
        _playerDeath?.Invoke(this, EventArgs.Empty);

        /*Debug.Log("ESTOY INVOCANDO LA ESCENA");
        // Reinicia la escena actual
       
        playerSpawner.SpawnPlayer();*/
    }

}