using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    /**
    TU codigo es puta mierda*/
    void Update()
    {
        if (Input.GetKey("w")){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,2000f * Time.deltaTime));
        }

        if (Input.GetKey("a")){
            gameObject.transform.Translate(-20F * Time.deltaTime,0,0);
        }
        
        if (Input.GetKey("d")){
            gameObject.transform.Translate(20F * Time.deltaTime,0,0);
        }
    }
}
