using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effectable : MonoBehaviour
{
    //主にステージのギミック、主人公、アイテムが保有するインスタンス

    //受ける影響のインターフェースだけ今は書いていけばいいと思う
    protected GameObject entity;
    
    public Effectable(GameObject gameObject){
        entity = gameObject;
    }

    public GameObject Entity{
        set {this.entity = value;}
        get {return this.entity;}
        }

    interface IEffectPalette{
       void Ef_AddForce(Vector3 vector3);
       void Ef_StateWrite();
       void Ef_Vanish();
   }

}
