using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBots : MonoBehaviour
{
    public GameObject mazeBot;
    bool deleteBot = false;
    public GameObject script;

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
        // Set the new spawnpoint and disable the projectileLauncher
        if (hit.gameObject.tag == "SpawnTrigger")
        {
            Debug.Log("new spawn");
            deleteBot = true;
            script.SetActive(false);
        }

        // Enable the bot in the maze and enable the projectileLauncher
        if (hit.gameObject.tag == "Hallway")
        {
            mazeBot.SetActive(true);
            script.SetActive(true);
        }

    }
}
