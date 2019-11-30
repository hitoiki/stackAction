using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDemo : MonoBehaviour
{
    //テスト用なので後で改善する
    public Rigidbody rb;
    public float speed;

    private Vector3 direction;
    // Start is called before the first frame update
    void Update(){
        KeyVectorCheck();
    }

    // Update is called once per frame
    Vector3 KeyVectorCheck()
    {
        direction = Vector3.zero;
         if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space))
        {
            direction += Vector3.up;
        }

        if (Input.GetKey(KeyCode.S)){
            direction += Vector3.up * (-1.0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.right * (-1.0f);
        }
        return direction;
    }

    void FixedUpdate(){
        if(KeyVectorCheck() != Vector3.zero){
        rb.velocity = KeyVectorCheck()*speed;
        }
    }
}