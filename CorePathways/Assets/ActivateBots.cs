using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBots : MonoBehaviour
{
    public GameObject mazeBot;
    bool deleteBot = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(deleteBot == true)
        {
            Destroy(mazeBot);
        }
    }

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "SpawnTrigger")
        {
            Debug.Log("new spawn");
            deleteBot = true;
        }

        if (hit.gameObject.tag == "Hallway")
        {
            mazeBot.SetActive(true);
        }
    }
}
