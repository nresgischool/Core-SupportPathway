using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeySystem
{
    public class PlatformController : MonoBehaviour
    {
        [SerializeField] private bool door = false;
        [SerializeField] private bool platform = false;

        [SerializeField] private KeyInventory _keyInventory = null;

        private KeyDoorController doorObject;

        private void Start()
        {
            if (door)
            {
                doorObject = GetComponent<KeyDoorController>();
            }
        }

        public void ObjectInteraction()
        {
            if (door)
            {
                doorObject.PlayAnimation();
            }

            else if (platform)
            {
                _keyInventory.hasKey = true;
                gameObject.SetActive(false);
            }
        }
    }
}
