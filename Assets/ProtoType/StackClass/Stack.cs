using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Stack : MonoBehaviour
{
    //stackのクラス
    //向きの情報が必要になる場合はおいおい考える
    //スタックによって必要な情報、行う処理がえぐいバラバラなので
    //Effectableはやはり必要かもしれない

    /*
    主人公には力学的操作（属性、ダメージ、キャラクターの形とかも）の受付を用意してもらって、
    スタックはそいつに渡すかギミック作るかでやる感じ
    リズムとかはスタックが副作用を持つ感じで
    */

    public abstract bool Sencer(Transform position);
    public abstract Vector3 Action();
    public Rigidbody rb{get;set;}

    public void Boot(){
        if(Sencer(rb.transform)){
            rb.velocity += Action();
        }
    }


}
