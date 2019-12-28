using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Stack : MonoBehaviour
{
    //stackのクラス
    //向きの情報が必要になる場合はおいおい考える
    //スタックによって必要な情報、行う処理がえぐいバラバラなので
    //Effectableはやはり必要かもしれない

    /*スタックをなめていた
    ヤバいよマジヤバい
    世界の時間止めるとかリズムでパワーアップとか平気でいってるもん
    規格化から最も遠い存在なのではないか？

    …規格化してみる
    出力する影響で分けていく（影響を与えていくクラスのため）

    主人公の挙動（速度、位置、重力方向）
    主人公の形の変化
    ギミックの生成
    他のギミックの操作
    地形の物理的性質の変化（沈むアクションのみ）
    時間操作（採用しなくても何とかなるか？）
    属性操作

    こんなところか

    アイデアを見て思ったのはモノを出して、そいつを基準にワープ、速度操作を行うってのが多いと感じた
    主人公には力学的操作（属性、ダメージ、キャラクターの形とかも）の受付を用意してもらって、
    スタックはそいつに渡すかギミック作るかでやる感じかな
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
