using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myDoorControllerOffice : MonoBehaviour
{
    private Animator doorAnim;
    private bool doorOpen = false;
    [SerializeField] private string doorOpenAnim = "DoorOpen";
    [SerializeField] private string doorCloseAnim = "DoorClose";

    void Awake()
    {
        doorAnim = gameObject.GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if (!doorOpen)
        {
            doorAnim.Play("DoorOpen2", 0, 0.0f);
            doorOpen = true;
            Debug.Log("Door Open");
        }
        else
        {
            doorAnim.Play("DoorClose2", 0, 0.0f);
            doorOpen = false;
            Debug.Log("Door Closed");
        }
    }
}
