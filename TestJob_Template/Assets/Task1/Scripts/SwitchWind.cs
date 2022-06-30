using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWind : MonoBehaviour
{
    public Animator animator;

    public void WindOnOff()
    {
        if (animator.GetBool("WindOn") == false)
            animator.SetBool("WindOn", true);
        else
            animator.SetBool("WindOn", false);
    }
}
