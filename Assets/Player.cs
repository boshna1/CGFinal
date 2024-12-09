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
        Mathf.Clamp(speed, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            isAccelerating = true;
            Accelerate();
            moveVector = Vector3.forward;
            rb.velocity = moveVector * speed;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            isAccelerating = false;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            transform.LookAt(Vector3.left);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.LookAt(Vector3.left);
        }
        if (!isAccelerating && speed > 0)
        {
            speed -= 0.05f;
        }
    }

    void Accelerate()
    {
        if (speed < 3)
        {
            speed += 0.01f;
        }
        
    }
}
