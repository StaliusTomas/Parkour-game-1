using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float SensX;
    public float SensY;

    public Transform orientation;
    float RotateY;
    float RotateX;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * SensX;
        float MouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * SensY;

        RotateY += MouseX;
        RotateX -= MouseY;
        RotateX = Mathf.Clamp(RotateX, -90f, 90f);

        transform.rotation = Quaternion.Euler(RotateX, RotateY, 0);
        orientation.rotation = Quaternion.Euler(0, RotateY, 0);
    }
}
