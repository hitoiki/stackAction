﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StacklyBlock : Stack
{

    public GameObject obj;
    float cooltimeCount;
    public float cooltime = 0.5f;
    public override Vector3 Action() {
        rb.position += Vector3.up * 0.5f;
        Instantiate (obj,rb.position - Vector3.up * 0.5f, Quaternion.identity);
        cooltimeCount = cooltime; 
        return Vector3.zero;
    }


    public override bool Sencer(Transform position)
    {
        Count();
        if(cooltimeCount > 0){
            return false;
        }else return true;        
    }

    void Update(){
        Count();
    }

    void Count(){
      if(cooltimeCount >= 0){
        cooltimeCount -= Time.deltaTime;
        }else cooltimeCount = 0;  
    }
}

