using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{ 

  // What to follow
    public GameObject player;
    //To put the camra in position
    private Vector3 offset = new Vector3(0, 8, -9);
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void LateUpdate()
    {
      transform.position = player.transform.position + offset;

    }
}
