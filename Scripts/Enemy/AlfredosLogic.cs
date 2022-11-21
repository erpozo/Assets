using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlfredosLogic : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed;
    // Start is called before the first frame update
    private void Awake() {

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if ( == pointA)
        {
            goTo(pointB);
        }
        else
        {
            goTo(pointA)
        }
    }

    public void goTo(Transform point){
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, point.position, step);
    }
}
