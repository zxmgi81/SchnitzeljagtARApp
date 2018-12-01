using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetrianglemove : MonoBehaviour {

    public bool FaceRight;
    public float speed = 50;
    public float power = 12;

    //Optional: in case if we want change speeds depending on difficulty
    //otherwise to be initialized up

    void Update()
    {
        MakeTheMove();
    }

    void MakeTheMove()
    {
        float moveOnX = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveOnX * speed, gameObject.GetComponent<Rigidbody2D>().velocity.y, 0);
        movement *= Time.deltaTime;
        transform.Translate(movement);
        if (Input.GetKeyDown("space"))
        {
            Jump();
        }
    }
    void Jump()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, power), ForceMode2D.Impulse);
    }

}
