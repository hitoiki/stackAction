using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManage : MonoBehaviour
{
    public StacklySencer st_Sencer;
    public Rigidbody rb;

    [System.Serializable]
    public delegate Vector3 Action(bool valid);

}
