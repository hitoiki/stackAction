using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectableAdapter : MonoBehaviour
{
    //何とかしてEffectableをインスペクター上で上手いこと扱いたい
    //普通にEffectableをMonoBehaviourで書けってのはある
    //でもそれだと統一的に記述できないので…やっぱり書いてく

    /*こいつの目的は、外部からのアクセスを補助すること
    インスペクター上でEffectableを上手く扱うこと
    */

    public Effectable effectable;
    
}
