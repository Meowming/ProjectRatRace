using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncAnimation : MonoBehaviour, ITriggerable
{
    public Animator animator;
    public string clipName;
    void ITriggerable.OnTriggered()
    {
        animator.Play(clipName);
    }

    public void PlayAnimation()
    {
        animator.Play(clipName);
    }
    // Start is called before the first frame update
    void Start()
    {
    }
}