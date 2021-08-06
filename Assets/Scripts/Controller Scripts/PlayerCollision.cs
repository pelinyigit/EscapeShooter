using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public GameObject FailCanvas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           FailCanvas.SetActive(true);
           Time.timeScale = 0;
        }
    }
}
