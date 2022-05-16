using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileKnockback : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 99999999);
        }
    }
}
