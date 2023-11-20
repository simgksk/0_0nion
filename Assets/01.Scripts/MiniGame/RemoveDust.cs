using System.Collections;
using UnityEngine;

public class RemoveDust : MonoBehaviour
{
    Rigidbody2D rigid;
    Collider2D collider;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        Click();
    }

    private void Click()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                rigid.gravityScale = 1;
                Destroy(gameObject, 2);

                collider.enabled = false;

            }
        }
    }
}
