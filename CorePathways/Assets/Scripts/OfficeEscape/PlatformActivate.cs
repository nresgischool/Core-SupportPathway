using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeySystem
{
    public class PlatformActivate : MonoBehaviour
    {
        public GameObject destroy;
        [SerializeField] private bool isCorrect = false;
        [SerializeField] private KeyInventory _keyInventory = null;

        //Destroy and object if two unrelated objects come in contact
        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.tag == "comCube")
            {
                Debug.Log("Collision");
                ChangeMyColor();
                if(!isCorrect)
                {
                    Destroy(destroy);
                    _keyInventory.hasKey = true;
                }
            }
        }
        //Changes the colour of the platform depending on if it opens the door or not
        void ChangeMyColor()
        {
            //Changes to green when correct platform
            if (!isCorrect)
            {
                GetComponent<Renderer>().material.color = Color.green;
            }

            //Changes to red when incorrect platform
            else
            {
                GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}
