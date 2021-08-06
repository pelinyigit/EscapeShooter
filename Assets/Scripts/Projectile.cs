using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float speed;
    
    public Vector3 Direction { get; set; }

    void Update()
    {
        transform.Translate(-Direction * speed * Time.deltaTime, Space.World);        
    }

    private void OnBecameInvisible()
    {
        if (gameObject != null)
        {

            Destroy(gameObject);
        }
    }
}
