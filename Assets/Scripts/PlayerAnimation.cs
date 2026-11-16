using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // Falling State
        if (rb.linearVelocityY < -0.1f) {
            animator.SetBool("IsFalling", true);
        } else {
            animator.SetBool("IsFalling", false);
        }

        // Moving State
        if (rb.linearVelocityX > 0.2f) {
            Debug.Log("moving");
        }
    }
}
