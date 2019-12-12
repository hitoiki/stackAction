using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effectable
{
    //主にステージのギミック、主人公、アイテムが保有するインスタンス

    //受ける影響の抽象クラスだけ今は書いていけばいいと思う
    protected GameObject entity;

    public Effectable(GameObject gameObject)
    {
        entity = gameObject;
    }

    public GameObject Entity
    {
        set { this.entity = value; }
        get { return this.entity; }
    }

    public abstract void Ef_AddForce(Vector3 vector3);
    public abstract void Ef_StateWrite();
    public abstract void Ef_Vanish();
/*
    public class Adapter : MonoBehaviour
    {
        public GameObject interentity;

        public void Ad_Set(){
            
        }
    } 
    */
}
