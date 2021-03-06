﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchSenser : MonoBehaviour
{
    //接触の状況を確認するメソッド
    
    //これが接地しているかの真理値

    //　レイを伸ばして接地判定に用いる
    public Transform rayPosition;
    public float rayRange = 1.0f; 
    private Transform demoHit;
    private float distanceFromTargetObj;
    public float raysize;
    private RaycastHit hit;

    bool valid;
    void Update()
    {
        demoHit = ToucherBox(rayPosition,Vector3.down * rayRange,raysize);
        if(demoHit != null){
        Debug.Log(demoHit.name);
        valid = true;
        }else valid = false;
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
        if(valid){
        Gizmos.color = Color.green;
        }else Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position +((Vector3.down) * distanceFromTargetObj) - Vector3.down*(raysize), Vector3.one * raysize);
    }

}