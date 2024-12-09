
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
        if (Input.GetKey(KeyCode.S))
        {
            isAccelerating = false;
            moveVector = Vector3.back;
            rb.velocity = moveVector * speed;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            isAccelerating = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 1, 0), 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 1, 0), -1);
        }
        if (!isAccelerating && speed > 0)
        {
            speed -= 0.05f;
        }
    }

    void Accelerate()
    {
        if (speed < 1)
        {
            speed += 0.01f;
        }
        
    }
}
