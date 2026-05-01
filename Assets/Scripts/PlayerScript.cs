using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    Rigidbody _rb;
    Animator _animator;
    SpriteRenderer _renderer;

    public float velocidad;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //Movimiento
        //Time.deltaTime hace que el movimiento sea metros/segundo y no metros/frame
        Vector2 moveInput = InputSystem.actions["Move"].ReadValue<Vector2>();
        transform.Translate(moveInput.x * velocidad * Time.deltaTime, 0,  moveInput.y * velocidad * Time.deltaTime);

        //Animacion Mov
        /*
        if (moveInput.x != 0)
        {
            _animator.SetBool("estaMoviendo", true);
        }
        else
        {
            _animator.SetBool("estaMoviendo", false);
        }
        */

        //Flip del personaje
        if (moveInput.x < 0)
        {
            _renderer.flipX = false;
        }
        else if (moveInput.x > 0)
        {
            _renderer.flipX = true;
        }
        
    }
}