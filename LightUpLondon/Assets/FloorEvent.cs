using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorEvent : MonoBehaviour
{
    public CircleCollider2D circle;

    public EdgeCollider2D floor;

  /*  private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetButtonDown("Down"))
            {
                floor.enabled = false;
            }

            if (Input.GetButtonUp("Down"))
            {
                floor.enabled = true;
            }
        }
    }*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Down") && circle.IsTouching(floor) == true)
        {
            floor.enabled = false;
            // onGround = true;
        }
        else if (Input.GetButtonUp("Down") && circle.IsTouching(floor) == false)
        {
            floor.enabled = true;
        }
    }
}
