using UnityEngine;

public class LampAnimatorController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Inside Color Change!");
            animator.SetTrigger("ColorChange");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("Scaling");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("Spinning");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("Hover");
        }
    }
}