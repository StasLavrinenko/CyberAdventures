using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [Space]
    [SerializeField] private LayerMask _terrainLayer;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private SpriteRenderer _sr;
    [SerializeField] private Animator _anim;

    [Space]
    [Range(0f, 10f)] public float _speed;
    [Range(0f, 5f)] public float _groundDistance;

    private bool _stopMoving;
    private bool _moveRightUp;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        RaycastHit _hit;
        Vector3 _castPos = transform.position;
        _castPos.y += 1;

        if(Physics.Raycast(_castPos, -transform.up, out _hit, Mathf.Infinity, _terrainLayer))
        {
            if(_hit.collider != null)
            {
                Vector3 _movePos = transform.position;
                _movePos.y = _hit.point.y + _groundDistance;
                transform.position = _movePos;
            }
        }

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 _moveDirection = new Vector3(x, 0f, y);
        _rb.velocity = _moveDirection * _speed;

        HorizontalMove(x);
        MoveUp(y);
        MoveDown(y);



        // Розворот персонажа в сторону руху
        if (x != 0 && x < 0) _sr.flipX = true;
        else if (x != 0 && x > 0) _sr.flipX = false;

    }

    private void HorizontalMove(float x) //Рух вліво - вправо
    {
        _anim.SetFloat("HorizontalMove", Mathf.Abs(x));
    } 

    private void MoveUp(float y) //Рух уверх
    {
        if (y == 0) _anim.SetTrigger("StopMoving");

        _anim.SetFloat("VerticalMove", y);
    }

    private void MoveDown(float y) //Рух вних
    {
        if (y == 0) _anim.SetTrigger("StopMoving");

        _anim.SetFloat("VerticalMove", y);
    }

}
