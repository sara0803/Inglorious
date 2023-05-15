using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour


{
    
    public void LoadScene(string _scene)
    {
        Debug.Log("HOLAAAAAAAAAAAAAAAAA");
        SceneManager.LoadScene(_scene);
        
    }
    
    
    
}
