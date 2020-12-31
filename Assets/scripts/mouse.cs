using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D player;
    Vector2 player_size;
    void Start()
    {
        player_size = gameObject.GetComponent<SpriteRenderer>().bounds.extents;
    }

    // Update is called once per frame
    
    
    private void FixedUpdate()
    {
        player_size = gameObject.GetComponent<SpriteRenderer>().bounds.extents;
        float player_x = transform.position.x;
        float player_y = transform.position.y;
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(mousePos.x<player_x+player_size.x&& mousePos.x > player_x - player_size.x&&
               mousePos.y < player_y + player_size.y && mousePos.y > player_y - player_size.y)
            player.MovePosition(mousePos);
        }
       
    }
}
