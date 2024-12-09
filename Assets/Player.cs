using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 0;
    Rigidbody rb;
    Vector3 moveVector;
    bool isAccelerating = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            isAccelerating = true;
            Accelerate();
            moveVector = Vector3.forward * speed;
            rb.velocity = moveVector;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.LookAt(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.LookAt(Vector3.right);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            isAccelerating = false;
        }
        if (!isAccelerating)
        {
            speed -= 0.1f;
        }
    }

    void Accelerate()
    {
        speed += 0.05f;
    }
}
