using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    [SerializeField] float jumpSpeed;
    [SerializeField] float gravityModifier;
    [SerializeField] float speed;
    private int score = 0;

    public int GetScore() => score;

    public void IncreaseScore()
    {
        score += 10;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            rb.AddRelativeForce(Vector3.up * jumpSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeTorque(Vector3.left * 0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeTorque(Vector3.right * 0.1f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeTorque(Vector3.forward * 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeTorque(Vector3.back * 0.1f);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddRelativeTorque(Vector3.down * 0.1f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            rb.AddRelativeTorque(Vector3.up * 0.1f);
        }
    }

}
