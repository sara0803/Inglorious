using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;



public class ShowGameOverMenu : MonoBehaviour
{
    [SerializeField] private GameObject _menuGameOver;
    private PlayerDeath _gameOver;

    private void Update()
    {
        _gameOver = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDeath>();
       // Debug.Log("LO ENCONTR�");
        _gameOver._playerDeath += ShowMenuGO;
        
    }

    private void ShowMenuGO(object sender, EventArgs e)
    {
        _menuGameOver.SetActive(true);
    }
    

}
    