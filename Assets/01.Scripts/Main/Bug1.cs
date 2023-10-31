using UnityEngine;

public class Bug1 : MonoBehaviour
{
    InputManager input;

    float bugSpeed = 1;
    int point = 10;

    Vector2 bug_Pos;
    RaycastHit2D bug_Hit;

    private void Awake()
    {
        input = GetComponent<InputManager>();
    }

    void Start()
    {
        input.onMouseDown += BugDie;
    }

    private void OnDestroy()
    {
        input.onMouseDown -= BugDie;
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += Vector3.right * bugSpeed * Time.deltaTime;
    }

    private void BugDie()
    {
        bug_Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        bug_Hit = Physics2D.Raycast(bug_Pos, Vector2.zero, 0);

        if (bug_Hit.collider != null && bug_Hit.collider.CompareTag("Bug1"))
        {
            Destroy(gameObject);
            GameManager.gameManager.AddCoin(point);
        }

    }
}
