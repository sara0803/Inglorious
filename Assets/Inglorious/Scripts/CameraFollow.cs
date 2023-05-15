using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   public GameObject _player;
   
       
       void Update()
       {
           
            if (_player!= null)
            {
                Vector3 postion = transform.position;
                postion.x = _player.transform.position.x;
                postion.y = _player.transform.position.y + 2;
                transform.position = postion;
            }
            

           
       }
}
