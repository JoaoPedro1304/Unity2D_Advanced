using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2D : MonoBehaviour
{
   Vector3 offset = new Vector3(-1.65f,0.53f,-0.77f);
   public GameObject player;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
