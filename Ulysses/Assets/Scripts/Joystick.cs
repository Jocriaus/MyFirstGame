using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    public Transform player1;
    public float speed = 5.0f;
    public bool BeingTouch = false;
    private Vector2 pointA;
    private Vector2 pointB;

    public Transform Outercircle;
    public Transform Innercircle;

    public SpriteRenderer innercirclesprite;
    public SpriteRenderer outercirclesprite;

    // Start is called before the first frame update
    void Start()
    {
        outercirclesprite = Outercircle.GetComponent<SpriteRenderer>();
        innercirclesprite = Innercircle.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
            Innercircle.transform.position = pointA;
            Outercircle.transform.position = pointA; 
            innercirclesprite.enabled = true;
            outercirclesprite.enabled = true;

        }
        if (Input.GetMouseButton(0)) {
            BeingTouch = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }
        else {
            BeingTouch = false;
        }
    }

    private void FixedUpdate() {

        if (BeingTouch) {
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            MoveCharacter(direction);
            Innercircle.transform.position = new Vector2(pointA.x + direction.x, pointA.y + direction.y );

        }
        else {
            innercirclesprite.enabled = false;
            outercirclesprite.enabled = false;
        }

    }

    void MoveCharacter(Vector2 direction) {

        player1.Translate(direction * speed * Time.deltaTime);

    }



}
