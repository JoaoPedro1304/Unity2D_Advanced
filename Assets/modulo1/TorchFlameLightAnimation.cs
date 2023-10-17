using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class TorchFlameLightAnimation : MonoBehaviour
{
    Light2D spotLight;
    float time;
    void Start()
    {
        spotLight = GetComponent<Light2D>();
    }

    
    void Update()
    {
        time += Time.deltaTime;
        if(time > Random.Range(0.1f,0.3f))
        {
            spotLight.intensity = Random.Range(0.7f,1.2f);         
            time = 0;
        }
        
    }
}
