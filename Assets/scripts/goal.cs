using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class goal : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeRemaining = 3f;
    public Rigidbody2D player1;
    public Rigidbody2D player2;
    public Rigidbody2D ball;
    public int force = 60;
    bool replay = false;
    public int counter_player1 = 0;
    public int counter_player2 = 0;
    
    public TextMeshProUGUI score1;
    public TextMeshProUGUI score2;
    public TextMeshProUGUI Goal;
    int num = 1;
    void Start()
    {
        
    }
   public void GOOL()
    {
        player1.MovePosition(new Vector2(577.3f, 117.5f));
        player2.MovePosition(new Vector2(619.9f, 117.5f));
    }
    // Update is called once per frame
    void Update()
    {
        if (ball.velocity.magnitude != 40f)
           ball.velocity = ball.velocity.normalized * 50f;
        //Debug.Log(ball.velocity.magnitude);
        if (replay)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {

                timeRemaining = 3f;
                replay = false;
                Goal.enabled = false;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "left goal")
        {

            leftGoal();
        }
        if (col.name == "right goal")
        {

            rightGoal();
        }


    }
    public void rightGoal()
    {
        counter_player1++;
        replay = true;
        ball.MovePosition(new Vector2(611.9f, 117.5f));
        ball.velocity = new Vector2(0, 0);
        score1.text = counter_player1.ToString();
        GOOL();
        Goal.enabled = true;
    }
    public void leftGoal()
    {
        counter_player2++;
        replay = true;
        ball.MovePosition(new Vector2(585.7f, 117.5f));
        ball.velocity = new Vector2(0, 0);
        score2.text = counter_player2.ToString();
        GOOL();
        Goal.enabled = true;
    }
}
