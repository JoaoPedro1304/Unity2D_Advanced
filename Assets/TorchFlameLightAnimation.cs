using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class TorchFlameLightAnimation : MonoBehaviour
{
    Light2D spotLight;
    void Start()
    {
        spotLight = GetComponent<Light2D>();
    }

    
    void Update()
    {
        spotLight.intensity = Mathf.PingPong(Random.Range(Time.time,Time.time*0.5f),0.8f);
        Debug.Log(Time.time);
    }
}
