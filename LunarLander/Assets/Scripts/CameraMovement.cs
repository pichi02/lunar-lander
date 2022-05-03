using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Transform camTransform;
    private Camera cam;

    private float distance = 10f;
    private float currentX = 0f;
    private float currentY = 0f;

    private float sensivityX = 4f;
    private float sensivityY = 1f;

    private void Start()
    {
        camTransform = transform;
        cam = Camera.main;
    }
    private void Update()
    {
        if (!player.GameOver())
        {
            currentY -= Input.GetAxisRaw("Mouse Y") * sensivityY;
            currentX += Input.GetAxisRaw("Mouse X") * sensivityX;
            currentY = Mathf.Clamp(currentY, -50f, 50f);
        }
        
    }
    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rot = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = player.transform.position + rot * dir;
        camTransform.LookAt(player.transform.position);
    }
}
