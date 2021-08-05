using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  
    [SerializeField]
    private float speed;

    Vector3 firstTouchPosition = Vector3.zero;
    Vector3 deltaTouchPosition = Vector3.zero;
    Vector3 direction = Vector3.zero;

    Rigidbody body;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            firstTouchPosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            deltaTouchPosition = Input.mousePosition - firstTouchPosition;
            direction = new Vector3(deltaTouchPosition.x, 0f, deltaTouchPosition.y);

            body.velocity = direction.normalized * speed;
        }
        else
        {
            body.velocity = Vector3.zero;
        }
    }
}
    
