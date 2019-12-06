using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ef_DealDemo : MonoBehaviour
{
    public Ef_demo effectable;

    void Update(){
        if (Input.GetKey(KeyCode.W))
        {
            effectable.Ef_AddForce(Vector3.one);
        }

        if (Input.GetKey(KeyCode.S)){

        }

        if (Input.GetKey(KeyCode.D))
        {

        }
    }
}
