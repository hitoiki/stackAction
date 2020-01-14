using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDemo : MonoBehaviour
{
    // プロトタイプなので雑だよ
    void OnCollisionStay(Collision col)
    {
        Debug.Log("あたった");
        if(col.gameObject.name == "Demoplayer" && !Input.GetKey(KeyCode.N)){
            Destroy(this.gameObject,0.1f);
        }
    }
}
