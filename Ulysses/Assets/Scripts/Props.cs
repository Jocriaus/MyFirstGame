using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Props : MonoBehaviour
{


    public float propsSpeed = Scroller.GetScrollSpeed;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -propsSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.CompareTag("lowerwall")) {

            
            Destroy(this.gameObject);
        }
    }
}
