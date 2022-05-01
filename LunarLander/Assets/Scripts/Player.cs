using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private ParticleSystem particleSystem;
    [SerializeField] float jumpSpeed;
    [SerializeField] float gravityModifier;
    [SerializeField] float speed;
    private int score = 0;
    private float fuel = 1f;

    public int GetScore() => score;

    public void IncreaseScore(int num)
    {
        score += num;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        particleSystem = GetComponent<ParticleSystem>();
        Physics.gravity *= gravityModifier;
    }

    void Update()
    {
       
        Movement();
    }
    public void Movement()
    {
        if (!GameOver())
        {

            if (Input.GetMouseButton(0))
            {
                fuel -= 0.1f * Time.deltaTime;
                rb.AddRelativeForce(Vector3.up * jumpSpeed);
                if (!particleSystem.isPlaying)
                {
                    particleSystem.Play();
                }
            }
            else
            {
                if (particleSystem.isPlaying)
                {
                    particleSystem.Stop();
                }
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
        else
        {
            particleSystem.Stop();
        }
    }
    public bool GameOver()
    {
        return fuel <= 0;
    }
    public void IncreaseFuel()
    {
        fuel += 0.4f;
    }
    public float GetFuel()
    {
        return fuel;
    }
}
