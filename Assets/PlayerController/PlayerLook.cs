using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [Header("Mouse Look")]
    public float mouseSensitivity = 2f;

    public Transform cam;
    public Transform orientation;
    private float xRotation;
    private float yRotation;
    private float mouseX;
    private float mouseY;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        xRotation -= mouseY * mouseSensitivity;
        yRotation += mouseX * mouseSensitivity;

        cam.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        orientation.transform.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
