using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{
    public float jumpForce = 10;
    public Vector2 rayLenght;
    private Rigidbody2D rb2D;

    private void Awake(){
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, rayLenght);
    }

    void Start(){
        
    }
    // Update is called once per frame

    void Update()
    {
        if (isGrounded()){
            Jump(jumpForce);
        }
        Movement();
    }

    public void Movement()
    {

        if (Input.GetKey("a")){
            gameObject.transform.Translate(-20F * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d")){
            gameObject.transform.Translate(20F * Time.deltaTime, 0, 0);
        }
    }

    public void Jump(float force)
    {
        if (Input.GetKeyDown(KeyCode.W)){
            rb2D.AddForce(Vector2.up * force);
        }
    }

    public bool isGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), rayLenght);
        return !hit;
    }
}

   
