using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMove : MonoBehaviour
{
    [SerializeField]
    float speed = 1.0f;
    Vector2 inputAxis;
    private Rigidbody2D _rig;
    public Rigidbody2D Rig { get { return this._rig ? this._rig : this._rig = GetComponent<Rigidbody2D>(); } }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        inputAxis.x = Input.GetAxis("Horizontal");
        inputAxis.y = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        Rig.MovePosition(Rig.position + inputAxis * speed);
    }
}
