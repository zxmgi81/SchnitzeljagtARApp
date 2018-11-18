using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    public float Acceleration;
    public float MaxMoveSpeed;
    public float JumpForce;
    
    private Rigidbody2D rb;
    private Transform camera;
    private BoxCollider2D col;

	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        camera = Camera.main.transform;
        col = GetComponent<BoxCollider2D>();
	}
	

	void Update ()
    {
        HandleMovement();
	}


    void HandleMovement()
    {
        float xMove = Vector3.SignedAngle(Vector3.up, camera.rotation * Vector3.up, Vector3.forward) * -Acceleration;
        float yMove = rb.velocity.y;

        xMove = Mathf.Clamp(xMove, -MaxMoveSpeed, MaxMoveSpeed);
        if((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) 
            || Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics2D.OverlapCircle((transform.position + (Vector3)col.offset) + Vector3.down * (col.size.y/2f + 0.1f), 0.05f))
                 yMove += JumpForce;
        }

        rb.velocity = new Vector2(xMove, yMove);

    }
}
