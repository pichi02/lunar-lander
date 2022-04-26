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
            rb.AddRelativeTorque(Vector3.left * 0.1f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddRelativeTorque(Vector3.right * 0.1f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddRelativeTorque(Vector3.forward * 0.1f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddRelativeTorque(Vector3.back * 0.1f);
        }
        //if (Input.GetKey(KeyCode.Q))
        //{
        //    rb.AddRelativeTorque(Vector3.down * 0.1f);
        //}
        //if (Input.GetKey(KeyCode.E))
        //{
        //    rb.AddRelativeTorque(Vector3.up * 0.1f);
        //}
    }
}
