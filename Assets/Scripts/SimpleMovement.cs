using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float _movementSpeed = 3f;
    private Vector2 _moveDirection;
    private float _horizontalInput;

    [Space(10)]
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _moveDirection = Vector2.left;
            _spriteRenderer.flipX = true;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _moveDirection = Vector2.right;
            _spriteRenderer.flipX = false;
        }
        else
        {
            _moveDirection = Vector2.zero;
        }

        this.transform.Translate(_moveDirection * (_movementSpeed * Time.deltaTime));
    }

    private void Move2()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        // print(horizontalInput);

        if (_horizontalInput < 0)
        {
            _spriteRenderer.flipX = true;
        }
        else if (_horizontalInput > 0)
        {
            _spriteRenderer.flipX = false;
        }

        this.transform.Translate(_horizontalInput * (_movementSpeed * Time.deltaTime), 0, 0);
    }
}
