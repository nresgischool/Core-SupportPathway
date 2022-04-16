using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ButtonSystem
{
    public class ButtonDoorController : MonoBehaviour
    {
        private Animator doorAnim;
        private bool doorOpen = false;

        [Header("Animation Names")]
        [SerializeField] private string openAnimationName = "DoorOpen";
        [SerializeField] private string closeAnimationName = "DoorClose";

        [SerializeField] private int timeToShowUI = 1;
        //[SerializeField] private GameObject showDoorLockedUI = null;

        [SerializeField] private ButtonInventory _buttonInventory = null;


        [SerializeField] private int waitTimer = 1;
        [SerializeField] private bool pauseInteraction = false;

        private void Awake()
        {
            doorAnim = gameObject.GetComponent<Animator>();
        }

        private IEnumerator PauseDoorInteraction()
        {
            pauseInteraction = true;
            yield return new WaitForSeconds(waitTimer);
            pauseInteraction = false;
        }

        public void playAnimation()
        {
            if (_buttonInventory.hasRedButton)
            {
                openDoor();
            }
            else
            {
                StartCoroutine(ShowDoorLocked());
            }
        }

        IEnumerator ShowDoorLocked()
        {
            //showDoorLockedUI.SetActive(true);
            yield return new WaitForSeconds(timeToShowUI);
            //showdoorLockedUI.SetActive(false);
        }

        void openDoor()
        {
            if (!doorOpen && !pauseInteraction)
            {
                doorAnim.Play(openAnimationName, 0, 0.0f);
                doorOpen = true;
                StartCoroutine(PauseDoorInteraction());
            }
            else if (doorOpen && !pauseInteraction)
            {
                doorAnim.Play(closeAnimationName, 0, 0.0f);
                doorOpen = false;
                StartCoroutine(PauseDoorInteraction());
            }
        }
    }
}
