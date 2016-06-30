using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 _movement = new Vector3();
    public Transform Front;
    public Vector3 rotation;
    float speed = 0f;
    float maxSpeed = 7f;
    float minSpeed = 0f;
    float accel = .07f;
    float DeAccel = .05f;
    public float rotationSpeed;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = 0;
        float z = 0;

            _movement = new Vector3(x, 0f, z);
        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
        {
            rotationSpeed = -7;
        }else if (Input.GetKey(KeyCode.D))
        {
            rotationSpeed = 7;
        }
        else
        {
            rotationSpeed = 0;
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            speed += accel;
        }
        if (speed > maxSpeed)
        {
            speed = maxSpeed;
        }
        if (speed < minSpeed)
        {
            speed = minSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            speed -= DeAccel;
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

}
