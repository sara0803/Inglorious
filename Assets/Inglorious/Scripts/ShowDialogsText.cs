using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShowDialogsText : MonoBehaviour
{
    [SerializeField] public GameObject _menuDialog;
    
    private bool ban = true;


    private void Start()
    {
        
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && ban)
        {
            Debug.Log("ESTOY ENTRADOOOOOOOOOOOOOOOOOOOOOO");
            
            _menuDialog.SetActive(true);
            ban = false;
            Invoke("ExitPanel",7);
        }
    }
 
    
    public void ExitPanel()
    {
        _menuDialog.SetActive(false);
    }
}

    
     
    

