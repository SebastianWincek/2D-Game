using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Player : MonoBehaviour
{
    float horizontal;
    float vertical;
    Vector2 newPosition = new Vector2(5, 5);

    void Update()
    {
        BasicMovement();
        CheckBorder();
 
    }

    void BasicMovement()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(newPosition.x * horizontal, newPosition.y * vertical, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);
    }
    void CheckBorder()
    {
        if (transform.position.y >= 4.5f)
        {
            transform.position = new Vector3(transform.position.x, 4.5f, 0);
        }
        else if (transform.position.y <= -4.5f)
        {
            transform.position = new Vector3(transform.position.x, -4.5f, 0);
        }
        if (transform.position.x >= 10.4f)
        {
            transform.position = new Vector3(-10.4f, transform.position.y, 0);
        }
        else if (transform.position.x <= -10.4f)
        {
            transform.position = new Vector3(10.4f, transform.position.y, 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Player trafiony przez: " + collision);
    }
    
        
}
