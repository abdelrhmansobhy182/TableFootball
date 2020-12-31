using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 300f;
    public float timeRemaining1 = 4f;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI GameOver;
    public bool timerIsRunning = false;
    void Start()
    {
        timerIsRunning = true;
    }

    
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                GameOver.enabled = true;
                if (timeRemaining1 > 0)
                {
                    timeRemaining1 -= Time.deltaTime;
                    
                }
                else
                {
                    SceneManager.LoadScene("Demo");
                }
                
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
