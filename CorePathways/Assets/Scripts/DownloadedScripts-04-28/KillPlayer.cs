using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUPERCharacter;

public class KillPlayer : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.GetComponent<SUPERCharacterAIO>().getHealth() <= 1)
        {
            Debug.Log("gameEnd");
            Destroy(Player);
        }
    }
}
