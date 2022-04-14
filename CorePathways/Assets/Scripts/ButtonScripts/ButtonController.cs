using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private Animator buttonAnim;
    [SerializeField] private bool redButton = false;
    [SerializeField] private bool blueButton = false;

    [SerializeField] private bool blackButton = false;
    [SerializeField] private bool purpleButton = false;
    [SerializeField] private bool greenButton = false;
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
