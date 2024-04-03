using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W04_Panel_ControlAnimation : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (animator.GetInteger("Control") == 0 || animator.GetInteger("Control") == 2)
            {
                animator.SetInteger("Control", 1);
            }
            else if (animator.GetInteger("Control") == 1)
            {
                animator.SetInteger("Control", 2);
            }

        }
    }
}
