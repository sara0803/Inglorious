using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   public GameObject _player;
   
       
       void Update()
       {
           Vector3 postion = transform.position;
           postion.x = _player.transform.position.x;
           transform.position = postion;
       }
}
