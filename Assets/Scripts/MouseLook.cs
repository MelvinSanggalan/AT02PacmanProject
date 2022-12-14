using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 2.5f;
    public float drag = 1.5f;

    private Vector2 mouseDir;
    private Vector2 smoothing;
    private Vector2 result;
    private Transform character;

    private void Awake()
    {
        character = transform.parent; 
    }


    // Update is called once per frame
    void Update()
    {
        mouseDir = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")) * sensitivity;
        smoothing = Vector2.Lerp(smoothing, mouseDir, 1 / drag);
        result += smoothing;
        result.y = Mathf.Clamp(result.y, -70, 70);

        character.rotation = Quaternion.AngleAxis(result.x, character.up);
    }
}
