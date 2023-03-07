using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcsInverso : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator anim;
    [SerializeField] private float speed;

    private void Start()
    {
        StartCoroutine("Npc");
    }

    IEnumerator Npc()
    {
        anim.SetBool("Andando", true);
        rb.velocity = new Vector2(-speed, rb.velocity.y);

        yield return new WaitForSeconds(2f);

        anim.SetBool("Andando", false);
        rb.velocity = new Vector2(0, rb.velocity.y);
        Vector3 localScale = transform.localScale;
        localScale.x = 1f;
        transform.localScale = localScale;

        yield return new WaitForSeconds(5f);

        anim.SetBool("Andando", true);
        rb.velocity = new Vector2(speed, rb.velocity.y);

        yield return new WaitForSeconds(2f);

        anim.SetBool("Andando", false);
        rb.velocity = new Vector2(0, rb.velocity.y);
        localScale.x *= -1f;
        transform.localScale = localScale;

        yield return new WaitForSeconds(5f);

        StartCoroutine("Npc");
    }
}
