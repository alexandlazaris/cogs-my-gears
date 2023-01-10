using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    float speed = 10F;
    private Rigidbody rb;
    private Vector3 vec;
    [SerializeField]
    bool enabled = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        vec.x = 0;
        vec.y = 0;
        vec.z = 0;
    }

    void FixedUpdate ()
    {
        // accelerometer
        // Vector3 acc = Input.acceleration;
        // rb.AddForce(acc.x * speed, 0, acc.y * speed);
        
        // key control
        if(enabled)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));
        }
        
    }

    void Enable()
    {
        enabled = true;
        Debug.Log("can move player");
    }

    void Disable()
    {
        enabled = false;
        Debug.Log("cannot move player");
    }
}
 