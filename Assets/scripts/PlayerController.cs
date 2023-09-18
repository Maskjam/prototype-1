using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // for turning the car
    public float turnSpeed;
    // speed of vehicle
    public float speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
