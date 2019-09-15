using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalAnimation : MonoBehaviour
{
    private Animator _anim;
    public Animator Anim { get { return this._anim ? this._anim : this._anim = GetComponent<Animator>(); } }
    public Vector2 Direction { get; private set; }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputAxis = new Vector2((int)Input.GetAxis("Horizontal"), (int)Input.GetAxis("Vertical"));
        if (inputAxis != Vector2.zero) Direction = inputAxis;

        if (Input.GetKeyDown(KeyCode.W)) Direction = Vector2.up;
        if (Input.GetKeyDown(KeyCode.A)) Direction = Vector2.left;
        if (Input.GetKeyDown(KeyCode.S)) Direction = Vector2.down;
        if (Input.GetKeyDown(KeyCode.D)) Direction = Vector2.right;

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) ||
            Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D)) Direction = GetButtonDirection();

        if (Direction != Vector2.zero)
        {
            Anim.speed = 1.0f;
            Anim.SetFloat("x", Direction.x);
            Anim.SetFloat("y", Direction.y);
        }
        else
        {
            Anim.speed = 0.0f;
        }

    }

    Vector2 GetButtonDirection()
    {
        float x = (Input.GetKey(KeyCode.D)) ? 1.0f : (Input.GetKey(KeyCode.A)) ? -1.0f : 0.0f;
        float y = (Input.GetKey(KeyCode.W)) ? 1.0f : (Input.GetKey(KeyCode.S)) ? -1.0f : 0.0f;
        return new Vector2(x, y);
    }
}
