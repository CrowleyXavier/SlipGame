using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaControl : MonoBehaviour
{

    private const float SPEED = 0.1f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        if (Input.GetKey("left"))
        {
            pos.x -= SPEED;
        }
        else if (Input.GetKey("right"))
        {
            pos.x += SPEED;
        }
        else if (Input.GetKey("down"))
        {
            pos.y -= SPEED;
        }
        else if (Input.GetKey("up"))
        {
            pos.y += SPEED;
        }

        transform.position = pos;
    }
}
