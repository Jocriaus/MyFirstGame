using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    public BoxCollider2D Bcollider;
    public Rigidbody2D rb;

    private float height;
    private static float scrollspeed = 2f;
    
    public static float GetScrollSpeed {
        get {
            return scrollspeed;
        }
    }
    
    void Start()
    {
        Bcollider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        height = Bcollider.size.y;
        Bcollider.enabled = false;

        rb.velocity = new Vector2(0, -scrollspeed);

    }

    // Update is called once per frame
    void Update()
    {
       
        if(transform.position.y < -height) {

            Vector2 resetposition = new Vector2(0, height *2f);
            transform.position = (Vector2)transform.position + resetposition;

        }


    }
}
