using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCameraFixed : MonoBehaviour
{
    private Quaternion minimapCamera;

    void Start() 
    {
        minimapCamera = transform.rotation; 
    }
    void Update() 
    { 
        transform.rotation = minimapCamera; 
    }

}
