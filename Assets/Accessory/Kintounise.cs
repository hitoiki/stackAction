using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kintounise : MonoBehaviour
{
    public float cooltime = 1f;
    public Rigidbody rb;
    void Awake(){
        rb.AddForce(Vector3.up*5,ForceMode.Impulse);
    }
    void Update(){
        Count();
        if(cooltime==0){
            Destroy(this.gameObject,0);
        } 
    }

    void Count(){
      if(cooltime >= 0){
        cooltime -= Time.deltaTime;
        }else cooltime = 0;  
    }
}

