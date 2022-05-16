using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnImpact : MonoBehaviour
{
    public bool onImpact = false;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            //col.gameObject.GetComponent<Rigidbody>().AddForce((new Vector3(0, 0, 300)));
        }
        if(onImpact == true)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject, 1);
        }
    }
}
