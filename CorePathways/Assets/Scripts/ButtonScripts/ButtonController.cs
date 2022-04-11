using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private Animator buttonAnim;
    [SerializeField] private bool buttonDown = false;

    void Awake()
    {
        buttonAnim = gameObject.GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if (!buttonDown)
        {
            buttonAnim.Play("ButtonDown", 0, 0.0f);
            buttonDown = true;
            Debug.Log("Button Down");
        }
        else
        {
            buttonAnim.Play("ButtonUp", 0, 0.0f);
            buttonDown = false;
            Debug.Log("Button Down");
        }
    }
}