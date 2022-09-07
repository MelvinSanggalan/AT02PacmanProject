using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraLock : MonoBehaviour
{
    private Quaternion lockedRotation;

    // Start is called before the first frame update
    void Start()
    {
      lockedRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
      transform.rotation = lockedRotation;
    }

}
