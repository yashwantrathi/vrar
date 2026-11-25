
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public Animator animator;

    // Play Idle animation
    public void Idle()
    {
        animator.SetTrigger("idle");
    }

    // Play Walking animation
    public void Walk()
    {
        animator.SetTrigger("walk");
    }

    // Play Running animation
    public void Run()
    {
        animator.SetTrigger("run");
    }

    // Play Jumping animation
    public void Jump()
    {
        animator.SetTrigger("jump");
    }
}
