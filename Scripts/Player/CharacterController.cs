using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float jumpForce = 250f;
    public float moveSpeed = 10f;
    public float rayLenght;
    public Vector3 offset = new Vector3(0, -5, 0);
    private Rigidbody2D rb2D;
    public LayerMask floor;
    public LayerMask enemy;
    private void Awake(){
        rb2D = GetComponent<Rigidbody2D>();
    }


    void Start(){
        
    }
    // Update is called once per frame

    void Update(){

        Debug.DrawRay(transform.position, Vector2.down * rayLenght, Color.red);

        if (IsGrounded()){
            Jump(jumpForce);
        }
        Movement(moveSpeed);
        
    }

    public void Movement(float speed){

        float right = speed;
        float left = -speed;
        
        if (Input.GetKey(KeyCode.A)){
            Move(left);
        }

        if (Input.GetKey(KeyCode.D)){
            Move(right);
        }
    }

    public void Move(float force){
        transform.Translate(force * Time.deltaTime, 0, 0);
    }

    public void Jump(float force){
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)){
            rb2D.AddForce(Vector2.up * force);
        }
    }

    public bool IsGrounded(){
        Vector3 raycastPosition = transform.position + offset;
        RaycastHit2D hit = Physics2D.Raycast(raycastPosition, Vector2.down, rayLenght);
        if (hit.collider != null)
        {
            Debug.Log("Has colisionado con");
            return true;
        }
        return false;
    }
}

   
