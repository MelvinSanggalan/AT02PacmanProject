using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverviewMapCameraFixed : MonoBehaviour
{
    private Quaternion overviewCamera;

    void Start() 
    {
        overviewCamera = transform.rotation; 
    }
    void Update() 
    { 
        transform.rotation = overviewCamera; 
    }

}
