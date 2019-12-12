using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StacklyShot : MonoBehaviour
{
    public StacklySencer st_Sencer;
    public Rigidbody rb;
    public float shotpow;

    Vector3 sh_direction;
    bool wait = false;

    void FixedUpdate(){
        Debug.Log(st_Sencer.valid);

        sh_direction = Vector3.zero;

        if(Input.GetKey(KeyCode.RightShift)){        
         if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space))
        {
            sh_direction += Vector3.up;
        }

        if (Input.GetKey(KeyCode.S)){
            sh_direction += Vector3.up * (-1.0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            sh_direction += Vector3.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            sh_direction += Vector3.right * (-1.0f);
        }
        }
        
        if(sh_direction != Vector3.zero && !wait){
            rb.position += sh_direction.normalized * shotpow;
            Debug.Log("shot!");
            wait = true;
        }
        if(sh_direction == Vector3.zero){
            wait = false;
        }


        
    }
}
