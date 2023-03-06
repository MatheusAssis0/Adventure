using UnityEngine;
using DialogueEditor;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    [SerializeField]private float velocidade;
    [SerializeField]private float forcaPulo;
    private bool isFacingRight = true;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject sairMenu;
    [SerializeField] private GameObject optionsMenu;
    [SerializeField] private BoxCollider2D bCollider;
    [SerializeField] private Animator anim;
    private bool collisionPlatform;

    void Update()
    {
        if(ConversationManager.Instance != null && ConversationManager.Instance.IsConversationActive || sairMenu.activeSelf == true || pauseMenu.activeSelf == true || optionsMenu.activeSelf == true)
        {
            return;
        }
        else
        {
            if (Input.GetButtonDown("Jump") && IsGrounded())
            {
                rb.velocity = new Vector2(rb.velocity.x, forcaPulo);
            }
            if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
            {
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
            }
            horizontal = Input.GetAxisRaw("Horizontal");
            Flip();

            if (IsGrounded() && collisionPlatform == true)
            {
                if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
                {
                    bCollider.isTrigger = true;
                    Invoke("LigarColisor", 0.2f);
                }
            }
            if (rb.velocity.x == 0f)
            {
                anim.SetBool("Andando", false);
            }
        }
    }

    private void FixedUpdate()
    {
        if (ConversationManager.Instance != null && ConversationManager.Instance.IsConversationActive)
        {
            return;
        }
        else
        {
            rb.velocity = new Vector2(horizontal * velocidade, rb.velocity.y);
            anim.SetBool("Andando", true);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Plataforma"))
        {
            collisionPlatform = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Plataforma"))
        {
            collisionPlatform = false;
        }
    }

    private void LigarColisor()
    {
        bCollider.isTrigger = false;
    }
}
