using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float player_speed=0.8f;
    // Update is called once per frame
    void Update()
    {
        float xDirection=Input.GetAxis("Horizontal");
        float zDirection=Input.GetAxis("Vertical");
        Vector3 moveDirection=new Vector3(xDirection,0.0f,zDirection);
        transform.position += moveDirection*player_speed;    
    }
}
