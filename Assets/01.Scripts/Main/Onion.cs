using UnityEngine;

public class Onion : MonoBehaviour
{
    InputManager input;

    [SerializeField] GameObject onion_Information;

    Vector2 onion_Pos;
    RaycastHit2D onion_Hit;

    bool isInformation;

    private void Awake()
    {
        input = GetComponent<InputManager>();

        onion_Information.SetActive(false);
        isInformation = onion_Information;
    }

    void Start()
    {
        input.onMouseDown += OnOff_Information;
    }

    private void OnDestroy()
    {
        input.onMouseDown -= OnOff_Information;
    }

    private void Update()
    {
        GetKey_E();
    }

    private void GetKey_E()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isInformation == false)
            {
                onion_Information.SetActive(true);
                isInformation = true;
            }

            else
            {
                onion_Information.SetActive(false);
                isInformation = false;
            }
        }
    }

    private void OnOff_Information()
    {
        onion_Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        onion_Hit = Physics2D.Raycast(onion_Pos, Vector2.zero, 0);

        if (onion_Hit.collider != null && onion_Hit.collider.CompareTag("Onion"))
        {
            onion_Information.SetActive(true);
        }

    }
}
