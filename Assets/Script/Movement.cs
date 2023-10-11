using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    public float moveSpeed = 5.0f;

    void Update()
    {
        Vector2 movement = new Vector2();

        if (Input.GetKey(KeyCode.W))
        {
            movement.y += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement.y -= 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement.x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement.x += 1;
        }

        // Normalize movement vector (so diagonal movement isn't faster)
        movement.Normalize();

        transform.position += new Vector3(movement.x, movement.y, 0) * moveSpeed * Time.deltaTime;
    }


}
