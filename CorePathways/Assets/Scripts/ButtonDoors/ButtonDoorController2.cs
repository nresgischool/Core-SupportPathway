using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoorController2 : MonoBehaviour
{
    [SerializeField] private Animator doorAnim = null;
    [SerializeField] private Animator buttonAnim;

    [SerializeField] private bool isButton = false;

    private bool doorOpen = false;

    [SerializeField] private string openAnimationName;
    [SerializeField] private string closeAnimationName;

    [SerializeField] private int waitTimer = 1;
    [SerializeField] private bool pauseInteraction = false;

    void Start()
    {
        buttonAnim = gameObject.GetComponent<Animator>();
    }

    private IEnumerator PauseDoorInteraction()
    {
        pauseInteraction = true;
        yield return new WaitForSeconds(waitTimer);
        pauseInteraction = false;
    }

    public void PlayAnimation()
    {
        if(isButton)
        {
            buttonAnim.Play("PressDown", 0, 0.0f);
            DoorAnimations();
        }
    }

    
    void DoorAnimations()
    {
        // Door animations
        if (!doorOpen && !pauseInteraction)
        {
            doorAnim.Play("DoorOpen", 0, 0.0f);
            doorOpen = true;
            StartCoroutine(PauseDoorInteraction());
        }

        else if (doorOpen && !pauseInteraction)
        {
            doorAnim.Play("DoorClose", 0, 0.0f);
            doorOpen = false;
            StartCoroutine(PauseDoorInteraction());
        }
    }
}
