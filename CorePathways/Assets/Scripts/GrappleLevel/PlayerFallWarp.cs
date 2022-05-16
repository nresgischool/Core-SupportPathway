using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallWarp : MonoBehaviour
{
    public GameObject player;
    public GameObject warpPoint;
    public GameObject warpPoint2;
    public float teleportFloorLevel;
    public bool spawnNew = false;

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y <= teleportFloorLevel)
        {
            if (spawnNew == true)
            {
                player.transform.position = warpPoint2.transform.position;
            }
            else
            {
                player.transform.position = warpPoint.transform.position;
            }

        }
    }
    // Detect collision with the SpawnTrigger tag to set a new spawnpoint
    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "SpawnTrigger")
        {
            Debug.Log("new spawn");
            spawnNew = true;
        }
    }
}
