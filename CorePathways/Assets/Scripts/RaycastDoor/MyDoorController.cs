using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDoorController : MonoBehaviour
{
    private Animator doorAnim;
    private bool doorOpen = false;

    void Awake()
    {
        doorAnim = gameObject.GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if(!doorOpen)
        {
            doorAnim.Play("DoorOpen", 0, 0.0f);
            doorOpen = true;
            Debug.Log("Door Open");
        }
        else
        {
            doorAnim.Play("DoorClose", 0, 0.0f);
            doorOpen = false;
            Debug.Log("Door Closed");
        }
    }
}
