using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StacklyJumpDemo : Stack
{
    public float jumppow = 10.0f;
    public float rayRange = 1.0f; 
    public float raysize = 1.0f;
    private Transform demoHit;
    private float distanceFromTargetObj;

    private RaycastHit hit;
    public override Vector3 Action() {
        return Vector3.up * jumppow ;
    }


    public override bool Sencer(Transform position)
    {
        demoHit = ToucherBox(position,Vector3.down * rayRange,raysize);
        if(demoHit != null){
        Debug.Log(demoHit.name);
        return true;
        }else return false;
     }

    Transform ToucherBox(Transform target,Vector3 Vec,float size){
        
        //boxcastにして、isTriggerは無視するように改良した     
        if(Physics.BoxCast (target.position - ((Vec.normalized) * size), Vector3.one * size * (0.5f) , (Vec.normalized) ,out hit , Quaternion.identity , Vec.magnitude))
        {
            /*if()//空中から接地したら、踏む準備する
            {
                stumpready = true;
            }*/
        distanceFromTargetObj = hit.distance;
        return hit.transform;

        }else{
        distanceFromTargetObj = Vec.magnitude;
        return null;
        }
    }

    void OnDrawGizmos() 
    {       
        //レイを疑似的に視覚化
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position +((Vector3.down) * distanceFromTargetObj) - Vector3.down*(raysize), Vector3.one * raysize);
    }

}

