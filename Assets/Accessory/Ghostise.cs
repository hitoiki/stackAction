using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghostise : MonoBehaviour
{

    public float cooltime = 1f;

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

