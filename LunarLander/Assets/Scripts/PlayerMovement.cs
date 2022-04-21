using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    [SerializeField] float jumpSpeed;
    [SerializeField] float gravityModifier;
    [SerializeField] float speed;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * jumpSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddRelativeTorque(Vector3.left);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddRelativeTorque(Vector3.right);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddRelativeTorque(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddRelativeTorque(Vector3.back);
        }

    }
}
