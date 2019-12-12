using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ef_demo : Effectable
{
    private Rigidbody rb;

    public Ef_demo(GameObject gameObject, Rigidbody rigidbody) : base(gameObject)
    {
        rb = rigidbody;
    }

    public Rigidbody Rb
    {
        set { this.rb = value; }
        get { return this.rb; }
    }

    public override void Ef_AddForce(Vector3 vector3)
    {
        Debug.Log("AddForce");
    }
    public override void Ef_StateWrite()
    {
        Debug.Log("StateWrite");
    }
    public override void Ef_Vanish()
    {
        Debug.Log("Vanish");
    }
}
