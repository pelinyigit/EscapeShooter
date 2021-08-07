using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemyKill : MonoBehaviour
{
    private int bigEnemyHealth;

    [SerializeField]
    private int maxBigEnemyHealth = 200;

    private void Start()
    {
        bigEnemyHealth = maxBigEnemyHealth;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && other != null)
        {
            if (bigEnemyHealth < maxBigEnemyHealth)
            {
                bigEnemyHealth = maxBigEnemyHealth - 100;
            }
            else if (bigEnemyHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
