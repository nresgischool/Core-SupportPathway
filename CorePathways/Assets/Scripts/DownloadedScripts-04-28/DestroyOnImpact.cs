using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnImpact : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Destroy(this.gameObject,1);
        if (col.gameObject.tag == "Enemy")
        {
            //col.gameObject.GetComponent<Rigidbody>().AddForce((new Vector3(0, 0, 300)));
        }
    }
}
