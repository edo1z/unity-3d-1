using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed = 10.0f;
    private Rigidbody rbody;

    void Start()
    {
        rbody = this.GetComponent<Rigidbody>();
        rbody.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
    }
}
