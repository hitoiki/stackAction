using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ef_DealDemo : MonoBehaviour
{
    public Rigidbody rigitbody;
    public GameObject gameObj;
    Ef_demo effect_demo;

    void Awake(){
        effect_demo =new Ef_demo(gameObj,rigitbody);
    }

    void Update(){
        if (Input.GetKey(KeyCode.W))
        {
            effect_demo.Ef_AddForce(Vector3.one);
        }

        if (Input.GetKey(KeyCode.S)){
            effect_demo.Ef_StateWrite();
        }

        if (Input.GetKey(KeyCode.D))
        {

        }
    }
}
