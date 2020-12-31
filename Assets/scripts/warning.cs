using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class warning : MonoBehaviour
{
    // Start is called before the first frame update
    public bool inside = false;
    public float timeRemaining = 5f;
    public TextMeshProUGUI timeText;
    public  bool player1 = false, player2 = false;
    
    public goal goal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(inside)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                if(player1)
                {
                    goal.leftGoal();
                }
                if(player2)
                {
                    goal.rightGoal();
                }
                timeRemaining = 10f;
                timeText.text = string.Format("{0:00}:{1:00}", 0, 10);

            }
        }
        else
        {

            timeRemaining = 10f;
            timeText.text = string.Format("{0:00}:{1:00}", 0, 10);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("inside");
        if (col.tag == "player")
        {
            inside = true;
        }

    }

    private void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("outside");
        if (col.tag == "player")
        {
            inside = false;
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
