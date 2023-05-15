using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBull : MonoBehaviour
{
    private Vector3 initPosition;
    // Start is called before the first frame update
    void Start()
    {
        initPosition = transform.position; 


     }

    // Update is called once per frame
    void Update()
    {
        float diferenceDistance = (transform.position.x) -( initPosition.x);
        if (diferenceDistance > 5f)
        {

            Destroy(gameObject);
            
        
        }
    }
}
