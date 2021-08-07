using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemyKill : MonoBehaviour
{
    private int simpleEnemyHeath;

    [SerializeField]
    private int maxSimpleEnemyHealth = 100;

    private void Start()
    {
        simpleEnemyHeath = maxSimpleEnemyHealth;
    }
    private void OnTriggerEnter(Collider other)
    { 
        if (other.tag == "Enemy" && other !=null)
        {

            Destroy(other.gameObject);
        } 
    }
}
