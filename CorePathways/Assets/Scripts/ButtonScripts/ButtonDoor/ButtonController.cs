using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private Animator buttonAnim;
    [SerializeField] private bool redButton = false;
    [SerializeField] private bool blueButton = false;

    [SerializeField] private bool orangeButton = false;
    [SerializeField] private bool purpleButton = false;
    [SerializeField] private bool greenButton = false;


    [Header("Animation Names")]
    [SerializeField] private string openAnimationName = "DoorOpen";
    [SerializeField] private string closeAnimationName = "DoorClose";

    [SerializeField] private int timeToShowUI = 1;
    [SerializeField] private GameObject showDoorLockedUI = null;

    //[SerializeField] private KeyInventory _KeyInventory = null;

    [SerializeField] private int waitTimer = 1;
    [SerializeField] private bool pauseInteraction = false;

    void Awake()
    {
        buttonAnim = gameObject.GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if (redButton)
        {
            buttonAnim.Play("Button", 0, 0.0f);
            redButton = true;
            Debug.Log("Button Down");
            if(blueButton)
            {
                buttonAnim.Play("Button", 0, 0.0f);
                blueButton = true;
                Debug.Log("Blue Button");
            }
        }
    }
}
