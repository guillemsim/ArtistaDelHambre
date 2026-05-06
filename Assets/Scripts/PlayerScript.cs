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
        ///Movimiento
        //Time.deltaTime hace que el movimiento sea metros/segundo y no metros/frame
        Vector2 moveInput = InputSystem.actions["Move"].ReadValue<Vector2>();
        transform.Translate(moveInput.x * velocidad * Time.deltaTime, 0,  moveInput.y * velocidad * Time.deltaTime);

        ///Animacion Mov
        /*
        //Animacion Caminar
        if (moveInput.x != 0)
        {
            _animator.SetBool("estaMoviendo", true);
        }
        else
        {
            _animator.SetBool("estaMoviendo", false);
        }
        //Animacion Swap Frente/Espalda
        if (moveInput.y != 0)
        {
            _animator.SetBool("estaSubiendo", true);
        }
        else
        {
            _animator.SetBool("estaSubiendo", false);
        }
        */

        //Flip del personaje Izd/Der
        if (moveInput.x < 0)
        {
            _renderer.flipX = false;
        }
        else if (moveInput.x > 0)
        {
            _renderer.flipX = true;
        }

        //Flip del personaje Arr/Ab
        if (moveInput.y < 0)
        {
            _renderer.flipY = false;
        }
        else if (moveInput.y > 0)
        {
            _renderer.flipY = true;
        }
        
    }
}