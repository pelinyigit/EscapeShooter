using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterBar : MonoBehaviour
{
    public Text enemyCount;
    public Slider slider;
    public GameObject SuccessCanvas;
    private int currentEnemyCount;
    private int maxEnemyCount;

    private void Start()
    {
        currentEnemyCount = maxEnemyCount;
        maxEnemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        slider.maxValue = maxEnemyCount;
        slider.value = currentEnemyCount;
       // enemyCount.text = (currentEnemyCount / maxEnemyCount * 100).ToString();
    }

    void Update()
    {
        CountEnemies();
    }

    void CountEnemies()
    {
        if(GameObject.FindGameObjectsWithTag("Enemy").Length != 0)
        {
            if (GameObject.FindGameObjectsWithTag("Enemy").Length < maxEnemyCount)
            {
                maxEnemyCount--;
                enemyCount.text = maxEnemyCount.ToString();
                SetProgress(currentEnemyCount);
                
            }
            else if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
            {
                currentEnemyCount = 0;
                enemyCount.text = currentEnemyCount.ToString();
                SetProgress(currentEnemyCount);
                SuccessCanvas.SetActive(true);
                Time.timeScale = 0;
            }
            else if (GameObject.FindGameObjectsWithTag("Enemy").Length == maxEnemyCount)
            {
                enemyCount.text = maxEnemyCount.ToString();
                SetProgress(maxEnemyCount);
            }
        }
       
    }

    void SetProgress(int p)
    { 
        slider.value = p;
    }

}