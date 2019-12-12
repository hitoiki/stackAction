using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StacklyJumpDemo : MonoBehaviour
{
    public StacklySencer st_Sencer;
    public Rigidbody rb;
    public float jumppow;

    void FixedUpdate(){
        if (st_Sencer.valid && Input.GetKey(KeyCode.W)){
            Debug.Log("jamp!");
            rb.AddForce(Vector3.up * jumppow);
        }
    }
}
