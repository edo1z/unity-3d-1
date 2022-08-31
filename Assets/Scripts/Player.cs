using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private float speed = 10.0f;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.transform.position.x > -4.5)
            {
                this.transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.transform.position.x < 4.5)
            {
                this.transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
    }
}
