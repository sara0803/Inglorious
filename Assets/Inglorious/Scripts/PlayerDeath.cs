using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerDeath : MonoBehaviour
{
    public event EventHandler _playerDeath;

    

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -27f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Monster"))
        {
            _playerDeath?.Invoke(this, EventArgs.Empty);
            Destroy(gameObject);
            

        }

    }

}