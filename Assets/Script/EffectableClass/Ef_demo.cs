using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ef_demo : Effectable
{    
    public Rigidbody rb;
   
    public Ef_demo(GameObject gameObject,Rigidbody rigidbody) : base (gameObject)
    {
        rb = rigidbody;
    }

       public void Ef_AddForce(Vector3 vector3){
           rb.AddForce(vector3);
       }
       void Ef_StateWrite(){
           Debug.Log("StateWrite");
       }
       void Ef_Vanish(){
           Destroy(entity);
       }
}
