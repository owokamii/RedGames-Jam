using UnityEngine;

public class CupboardDoorAnimation : MonoBehaviour
{
    private Animator animator;
    private bool isClicked = false;

    public BoxCollider2D doorClosed;
    public BoxCollider2D doorOpened;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        if(!isClicked)
        {
            isClicked = true;
            animator.SetBool("IsClicked", true);
            doorClosed.enabled = false;
            doorOpened.enabled = true;
        }

        else
        {
            isClicked = false;
            animator.SetBool("IsClicked", false);
            doorClosed.enabled = true;
            doorOpened.enabled = false;
        }
    }
}