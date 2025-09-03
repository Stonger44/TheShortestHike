using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float _movementSpeed = 3f;
    private Vector2 _moveDirection;

    [Space(10)]
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
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
}
