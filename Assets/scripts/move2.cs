using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D player1;
    public Transform p1;
    public int speed = 20;


    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.D))
        {
            player1.MovePosition(player1.position + new Vector2(speed, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {

            player1.MovePosition(player1.position + new Vector2(-speed, 0) * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.W))
        {
            player1.MovePosition(player1.position + new Vector2(0, speed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player1.MovePosition(player1.position + new Vector2(0, -speed) * Time.deltaTime);
        }
    }
}
