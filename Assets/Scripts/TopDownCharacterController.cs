using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class TopDownCharacterController : MonoBehaviour
    {
        public float speed;

        private Animator animator;
        private Rigidbody2D rb;

        private void Start()
        {
            animator = GetComponent<Animator>();
            rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");

            Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized;

            if (movement != Vector2.zero)
            {
                rb.velocity = movement * speed;
                animator.SetBool("IsMoving", true);

                // animation directions
                if (Mathf.Abs(horizontalInput) > Mathf.Abs(verticalInput))
                {
                    if (horizontalInput > 0)
                        animator.SetInteger("Direction", 2); // Right
                    else
                        animator.SetInteger("Direction", 3); // Left
                }
                else
                {
                    if (verticalInput > 0)
                        animator.SetInteger("Direction", 1); // Up
                    else
                        animator.SetInteger("Direction", 0); // Down
                }
            }
            else
            {
                rb.velocity = Vector2.zero;
                animator.SetBool("IsMoving", false);
            }
        }
    }
}
