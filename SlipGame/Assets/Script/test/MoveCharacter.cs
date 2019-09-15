using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class MoveCharacter : MonoBehaviour
{
    public readonly float SPEED = 0.1f;
    private Rigidbody2D rigidBody;
    private Vector2 input;
    public LayerMask mask;

    void Start()
    {
        this.rigidBody = GetComponent<Rigidbody2D>();
        // 衝突時にobjectを回転させない設定
        this.rigidBody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    private void Update()
    {
        // クリックした位置へのRay取得
Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
RaycastHit hit;

// クリックしたら
if (Input.GetMouseButtonDown(0))
{
// Ray飛ばす
if (Physics.Raycast(ray, out hit, 100f))
{
Debug.Log(hit.collider.name);
}
}

        // 入力を取得
        input = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
        if (Input.GetKey(KeyCode.Space))
        {


            Ray();
            Debug.Log("Ray");
        }
        
    }

    private void FixedUpdate()
    {
        if (input == Vector2.zero)
        {
            return;
        }
        // 既存のポジションに対して、移動量(vector)を加算する
        rigidBody.position += input * SPEED;
    }

    void Ray()
    {
        int layerMask = LayerMask.GetMask(new string[] { "ReaderAI", "ReaderChara", "Chacechara", "wall" });
        Ray2D ray = new Ray2D(transform.position, transform.up);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 1000f, layerMask);

        if (hit.collider != null)
        {
            if (hit.collider.tag == "wall")
            {
                Debug.Log("RayがPlayerに当たった");
            }
        }

    }

}
