
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    Rigidbody _rb;
    Animator _animator;
    SpriteRenderer _renderer;

    public float velocidad;
    public float _raycast;
    int _layerMask;


    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
        _layerMask = LayerMask.GetMask("Terreno");
    }

    void Update()
    {
        ///Movimiento
        //Time.deltaTime hace que el movimiento sea metros/segundo y no metros/frame
        Vector2 moveInput = InputSystem.actions["Move"].ReadValue<Vector2>();
        transform.Translate(moveInput.x * velocidad * Time.deltaTime, 0,  moveInput.y * velocidad * Time.deltaTime);

        ///Animacion Mov
        
        //Animacion Caminar. Hay movimiento en el eje X o en el eje Y? Si es asi, estaMoviendo = true, sino estaMoviendo = false
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
            _animator.SetBool("estaMoviendo", true);
        }
        else
        {
            _animator.SetBool("estaMoviendo", false);
        }
        

        if (moveInput.y > 0)
        {
            _animator.SetBool("estaDeEspalda", true);
        }
        else if (moveInput.y < 0)
        {
            _animator.SetBool("estaDeEspalda", false);
        }

        
        
        ///Flip del personaje
        //Izd/Der
        // if (moveInput.x < 0)
        // {
        //     _renderer.flipX = false;
        // }
        // else if (moveInput.x > 0)
        // {
        //     _renderer.flipX = true;
        // }
        

        /// Raycasting
        // Variable para definir la altura a la que esta el personaje
        float suspensionHeight = 0f + _raycast;
        // Teleporta al player al punto al que intersecta el suelo
        RaycastHit hit;
        Ray ray = new Ray(transform.position, Vector3.down);
        if (Physics.Raycast(ray, out hit, 6f, _layerMask))
        {
            transform.position = hit.point + hit.normal * suspensionHeight;
        }
        
    }
}