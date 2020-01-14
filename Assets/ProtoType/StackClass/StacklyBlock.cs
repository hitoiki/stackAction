using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StacklyBlock : Stack
{

    public GameObject obj;
    float cooltimeCount;
    public float cooltime = 0.5f;

    public int zandan = -1;
    int zandancapa = 10;
    public int reloadtime = 10;
    int reloading = 1;

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
        }

        if(zandan >= 0){
            zandan--;
            return true;
        }else {           
            return false;
        }

          
    }

    void Update(){
        Count();
    }


    void Count(){
      if(cooltimeCount >= 0){
        cooltimeCount -= Time.deltaTime;
        }else {
            cooltimeCount = 0; 
            reloading--;
            if(reloading == 0) {
                reloading = reloadtime;
                if(zandan < zandancapa)zandan++;
                
            }
        }
    }
}

