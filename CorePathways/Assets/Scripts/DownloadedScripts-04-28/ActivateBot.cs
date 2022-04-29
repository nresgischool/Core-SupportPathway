using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBot : MonoBehaviour
{
    public GameObject bot;
    Bot script;
    // Start is called before the first frame update
    void Start()
    {
        script = bot.GetComponent<Bot>();
        script.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            script.enabled = true;
        }
    }
}
