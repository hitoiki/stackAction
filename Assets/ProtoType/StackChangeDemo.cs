using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackChangeDemo : MonoBehaviour
{
    public List<Stack> stacks; 
    private Stack itemStack;

    public Rigidbody playerRb;
    void OnCollisionEnter(Collision col){
        itemStack = col.gameObject.GetComponent<Stack>();
        Debug.Log(itemStack);
        if(itemStack != null){

            if(itemStack != stacks[stacks.Count-1]){
            itemStack.rb = playerRb;
            stacks.Add(itemStack);
            stacks.RemoveAt(0);
            }
        }
    }
    
    void FixedUpdate(){
        if(Input.GetKey(KeyCode.Z)){
            stacks[stacks.Count-1].Boot();

        }
        if(Input.GetKey(KeyCode.X)){
            
        }
    }
}
